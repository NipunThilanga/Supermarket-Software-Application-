using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Splash
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-723Q2ES\MYSQLSERVER;Initial Catalog=supermarketdb;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            Con.Open();

            string query = "select ProdName,ProdQty from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void populatebills()
        {
            Con.Open();

            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            fillcombo();
            SellerNamelbl.Text = Loginform.Sellername;
        }

        private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProdPrice.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        int Grdtotal = 0;
        int n = 0;
        private void AddproductBtn_Click(object sender, EventArgs e)
        {
            if (ProdName.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);

                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(ORDERDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdName.Text;
                newRow.Cells[2].Value = ProdPrice.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                ORDERDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                Amtlbl.Text = " " + Grdtotal;
            }
        }

        private void AddsellsBtn_Click(object sender, EventArgs e)
        {
            if (BillID.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "insert into BillTbl values(" + BillID.Text + ", '" + SellerNamelbl.Text + "','" + Datelbl.Text + "'," + Amtlbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Order Added Successfully");

                    Con.Close();

                    populatebills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            /*if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }*/
        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BillID.Text = BillsDGV.SelectedRows[0].Cells[0].Value.ToString();
            int flag = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FAMILY SUPERMARKET", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: " + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("Seller Name: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date: " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("Code Space", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Red, new Point(270, 230));
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            populate();
            SellingForm main = new SellingForm();
            main.Show();
            this.ResumeLayout(false);
        }

        private void fillcombo()
        {
            // This Methord will bind the combobox with the database
            Con.Open();

            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            //CatCb.ValueMember = "CatName";
            //CatCb.DataSource = dt;
            Con.Close();
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform login = new Loginform();
            login.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BillID.Text == "")
                {
                    MessageBox.Show("Salect the Billid to Delete");
                }
                else
                {
                    Con.Open();

                    string query = "delete from BillTbl where Billid=" + BillID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Delete Successfully");

                    Con.Close();
                    populate();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
