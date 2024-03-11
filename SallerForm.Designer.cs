namespace Splash
{
    partial class SallerForm
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
            this.CategoryBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.Datelbl = new System.Windows.Forms.Label();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.SellerDGV = new System.Windows.Forms.DataGridView();
            this.DeletBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Spass = new System.Windows.Forms.RichTextBox();
            this.Sphone = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Sage = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sid = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LogoutLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CategoryBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.CategoryBtn.Location = new System.Drawing.Point(17, 256);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Size = new System.Drawing.Size(111, 38);
            this.CategoryBtn.TabIndex = 44;
            this.CategoryBtn.Text = "Categories";
            this.CategoryBtn.UseVisualStyleBackColor = false;
            this.CategoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.ExitBtn.Location = new System.Drawing.Point(1322, 16);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(42, 23);
            this.ExitBtn.TabIndex = 42;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RefreshBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.RefreshBtn.Location = new System.Drawing.Point(934, 58);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(115, 32);
            this.RefreshBtn.TabIndex = 26;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.Datelbl.ForeColor = System.Drawing.Color.White;
            this.Datelbl.Location = new System.Drawing.Point(1075, 15);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(47, 19);
            this.Datelbl.TabIndex = 25;
            this.Datelbl.Tag = "";
            this.Datelbl.Text = "Date";
            // 
            // ProductBtn
            // 
            this.ProductBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.ProductBtn.Location = new System.Drawing.Point(17, 150);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(111, 38);
            this.ProductBtn.TabIndex = 43;
            this.ProductBtn.Text = "Products";
            this.ProductBtn.UseVisualStyleBackColor = false;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // SellerDGV
            // 
            this.SellerDGV.AllowUserToResizeColumns = false;
            this.SellerDGV.AllowUserToResizeRows = false;
            this.SellerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellerDGV.BackgroundColor = System.Drawing.Color.White;
            this.SellerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SellerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellerDGV.Location = new System.Drawing.Point(517, 96);
            this.SellerDGV.Name = "SellerDGV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SellerDGV.RowHeadersVisible = false;
            this.SellerDGV.RowHeadersWidth = 51;
            this.SellerDGV.RowTemplate.Height = 29;
            this.SellerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellerDGV.Size = new System.Drawing.Size(679, 542);
            this.SellerDGV.TabIndex = 19;
            this.SellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerDGV_CellContentClick);
            // 
            // DeletBtn
            // 
            this.DeletBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeletBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.DeletBtn.Location = new System.Drawing.Point(277, 424);
            this.DeletBtn.Name = "DeletBtn";
            this.DeletBtn.Size = new System.Drawing.Size(94, 40);
            this.DeletBtn.TabIndex = 18;
            this.DeletBtn.Text = "DELETE";
            this.DeletBtn.UseVisualStyleBackColor = false;
            this.DeletBtn.Click += new System.EventHandler(this.DeletBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.EditBtn.Location = new System.Drawing.Point(151, 424);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(94, 40);
            this.EditBtn.TabIndex = 17;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.AddBtn.Location = new System.Drawing.Point(24, 424);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 40);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkOrange;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(20, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 38);
            this.label8.TabIndex = 3;
            this.label8.Text = "PASSWORD";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Spass
            // 
            this.Spass.BackColor = System.Drawing.Color.White;
            this.Spass.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spass.Location = new System.Drawing.Point(151, 352);
            this.Spass.Name = "Spass";
            this.Spass.Size = new System.Drawing.Size(220, 34);
            this.Spass.TabIndex = 4;
            this.Spass.Text = "";
            // 
            // Sphone
            // 
            this.Sphone.BackColor = System.Drawing.Color.White;
            this.Sphone.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sphone.Location = new System.Drawing.Point(151, 286);
            this.Sphone.Name = "Sphone";
            this.Sphone.Size = new System.Drawing.Size(220, 34);
            this.Sphone.TabIndex = 4;
            this.Sphone.Text = "";
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
            this.label5.Text = "PHONE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sage
            // 
            this.Sage.BackColor = System.Drawing.Color.White;
            this.Sage.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sage.Location = new System.Drawing.Point(151, 220);
            this.Sage.Name = "Sage";
            this.Sage.Size = new System.Drawing.Size(220, 34);
            this.Sage.TabIndex = 4;
            this.Sage.Text = "";
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
            this.label3.Text = "AGE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sname
            // 
            this.Sname.BackColor = System.Drawing.Color.White;
            this.Sname.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sname.Location = new System.Drawing.Point(151, 156);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(220, 34);
            this.Sname.TabIndex = 4;
            this.Sname.Text = "";
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
            // Sid
            // 
            this.Sid.BackColor = System.Drawing.Color.White;
            this.Sid.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sid.Location = new System.Drawing.Point(151, 100);
            this.Sid.Name = "Sid";
            this.Sid.Size = new System.Drawing.Size(220, 34);
            this.Sid.TabIndex = 4;
            this.Sid.Text = "";
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
            this.label4.Location = new System.Drawing.Point(371, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "MANAGE SELLERS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoutLbl
            // 
            this.LogoutLbl.AutoSize = true;
            this.LogoutLbl.BackColor = System.Drawing.SystemColors.Control;
            this.LogoutLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.LogoutLbl.Location = new System.Drawing.Point(22, 689);
            this.LogoutLbl.Name = "LogoutLbl";
            this.LogoutLbl.Size = new System.Drawing.Size(76, 23);
            this.LogoutLbl.TabIndex = 45;
            this.LogoutLbl.Text = "Logout";
            this.LogoutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogoutLbl.Click += new System.EventHandler(this.LogoutLbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.SellerDGV);
            this.panel1.Controls.Add(this.DeletBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Spass);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Sphone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Sage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Sname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Sid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(147, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 652);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(29, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "PHONE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 728);
            this.Controls.Add(this.CategoryBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ProductBtn);
            this.Controls.Add(this.LogoutLbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SallerForm";
            this.Text = "SallerForm";
            this.Load += new System.EventHandler(this.SallerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CategoryBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.DataGridView SellerDGV;
        private System.Windows.Forms.Button DeletBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox Spass;
        private System.Windows.Forms.RichTextBox Sphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Sage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Sid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LogoutLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}