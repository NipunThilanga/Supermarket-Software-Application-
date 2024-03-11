using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class SallerForm : Form
    {
        public SallerForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-723Q2ES\MYSQLSERVER;Initial Catalog=supermarketdb;Integrated Security=True");

        private void populate()
        {
            Con.Open();

            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sid.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            Sname.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            Sage.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            Sphone.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            Spass.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sid.Text == "" || Sname.Text == "" || Sage.Text == "" || Sphone.Text == "" || Spass.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update SellerTbl set SellerName='" + Sname.Text + "',SellerAge='" + Sage.Text + "',SellerPhone='" + Sphone.Text + "',SellerPass='" + Spass.Text + "' Where SellerId=" + Sid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Updated");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeletBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sid.Text == "")
                {
                    MessageBox.Show("Salect the Category to Delete");
                }
                else
                {
                    Con.Open();

                    string query = "delete from SellerTbl where SellerId=" + Sid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Delete Successfully");

                    Con.Close();

                    populate();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SallerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string query = "insert into SellerTbl values(" + Sid.Text + ", '" + Sname.Text + "'," + Sage.Text + "," + Sphone.Text + ",'" + Spass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Seller Added Successfully");

                Con.Close();

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform login = new Loginform();
            login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            SallerForm main = new SallerForm();
            main.Show();
            this.ResumeLayout(false);
        }
    }
}
