namespace Splash
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LogoutLbl = new System.Windows.Forms.Label();
            this.SellerBtn = new System.Windows.Forms.Button();
            this.Datelbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ProdAddbtn = new System.Windows.Forms.Button();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProdPrice = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdQty = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProdId = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoutLbl
            // 
            this.LogoutLbl.AutoSize = true;
            this.LogoutLbl.BackColor = System.Drawing.SystemColors.Control;
            this.LogoutLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.LogoutLbl.Location = new System.Drawing.Point(21, 685);
            this.LogoutLbl.Name = "LogoutLbl";
            this.LogoutLbl.Size = new System.Drawing.Size(76, 23);
            this.LogoutLbl.TabIndex = 43;
            this.LogoutLbl.Text = "Logout";
            this.LogoutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogoutLbl.Click += new System.EventHandler(this.LogoutLbl_Click);
            // 
            // SellerBtn
            // 
            this.SellerBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SellerBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.SellerBtn.Location = new System.Drawing.Point(39, 152);
            this.SellerBtn.Name = "SellerBtn";
            this.SellerBtn.Size = new System.Drawing.Size(83, 38);
            this.SellerBtn.TabIndex = 41;
            this.SellerBtn.Text = "Seller";
            this.SellerBtn.UseVisualStyleBackColor = false;
            this.SellerBtn.Click += new System.EventHandler(this.SellerBtn_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.Datelbl.ForeColor = System.Drawing.Color.White;
            this.Datelbl.Location = new System.Drawing.Point(1057, 28);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(47, 19);
            this.Datelbl.TabIndex = 24;
            this.Datelbl.Tag = "";
            this.Datelbl.Text = "Date";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(1318, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProdDGV
            // 
            this.ProdDGV.AllowUserToResizeColumns = false;
            this.ProdDGV.AllowUserToResizeRows = false;
            this.ProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.White;
            this.ProdDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdDGV.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProdDGV.Location = new System.Drawing.Point(532, 85);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProdDGV.RowHeadersVisible = false;
            this.ProdDGV.RowHeadersWidth = 51;
            this.ProdDGV.RowTemplate.Height = 29;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(662, 553);
            this.ProdDGV.TabIndex = 21;
            this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.DeleteBtn.Location = new System.Drawing.Point(277, 437);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 40);
            this.DeleteBtn.TabIndex = 18;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.EditBtn.Location = new System.Drawing.Point(151, 437);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(94, 40);
            this.EditBtn.TabIndex = 17;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ProdAddbtn
            // 
            this.ProdAddbtn.BackColor = System.Drawing.SystemColors.Control;
            this.ProdAddbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdAddbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.ProdAddbtn.Location = new System.Drawing.Point(24, 437);
            this.ProdAddbtn.Name = "ProdAddbtn";
            this.ProdAddbtn.Size = new System.Drawing.Size(94, 40);
            this.ProdAddbtn.TabIndex = 16;
            this.ProdAddbtn.Text = "ADD";
            this.ProdAddbtn.UseVisualStyleBackColor = false;
            this.ProdAddbtn.Click += new System.EventHandler(this.ProdAddbtn_Click);
            // 
            // CatCb
            // 
            this.CatCb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCb.ForeColor = System.Drawing.Color.DarkOrange;
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "ADMIN",
            "SALLER"});
            this.CatCb.Location = new System.Drawing.Point(151, 358);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(220, 29);
            this.CatCb.TabIndex = 9;
            this.CatCb.Text = "Seelct Category";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkOrange;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 38);
            this.label6.TabIndex = 3;
            this.label6.Text = "CATEGORY";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProdPrice
            // 
            this.ProdPrice.BackColor = System.Drawing.Color.White;
            this.ProdPrice.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice.Location = new System.Drawing.Point(151, 286);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(220, 34);
            this.ProdPrice.TabIndex = 4;
            this.ProdPrice.Text = "";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(20, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "PRICE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProdQty
            // 
            this.ProdQty.BackColor = System.Drawing.Color.White;
            this.ProdQty.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQty.Location = new System.Drawing.Point(151, 220);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(220, 34);
            this.ProdQty.TabIndex = 4;
            this.ProdQty.Text = "";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(20, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "QUANTITY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.White;
            this.ProdName.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.Location = new System.Drawing.Point(151, 156);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(226, 34);
            this.ProdName.TabIndex = 4;
            this.ProdName.Text = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(20, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProdId
            // 
            this.ProdId.BackColor = System.Drawing.Color.White;
            this.ProdId.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdId.Location = new System.Drawing.Point(151, 100);
            this.ProdId.Name = "ProdId";
            this.ProdId.Size = new System.Drawing.Size(226, 34);
            this.ProdId.TabIndex = 4;
            this.ProdId.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(384, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "MANAGE PRODUCTS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.CategoryBtn.Location = new System.Drawing.Point(21, 276);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Size = new System.Drawing.Size(110, 38);
            this.CategoryBtn.TabIndex = 42;
            this.CategoryBtn.Text = "Categories";
            this.CategoryBtn.UseVisualStyleBackColor = false;
            this.CategoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.ProdDGV);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.ProdAddbtn);
            this.panel1.Controls.Add(this.CatCb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ProdId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(147, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 652);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 728);
            this.Controls.Add(this.LogoutLbl);
            this.Controls.Add(this.SellerBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CategoryBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogoutLbl;
        private System.Windows.Forms.Button SellerBtn;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView ProdDGV;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button ProdAddbtn;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox ProdPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ProdQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ProdId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CategoryBtn;
        private System.Windows.Forms.Panel panel1;
    }
}