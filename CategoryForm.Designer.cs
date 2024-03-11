namespace Splash
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LogoutBtn = new System.Windows.Forms.Label();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.SallerBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Datelbl = new System.Windows.Forms.Label();
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CatAddBtn = new System.Windows.Forms.Button();
            this.CatDescTxt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CatNameTxt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CatidTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.AutoSize = true;
            this.LogoutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.LogoutBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.LogoutBtn.Location = new System.Drawing.Point(26, 691);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(76, 23);
            this.LogoutBtn.TabIndex = 44;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ProductBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.ProductBtn.Location = new System.Drawing.Point(21, 276);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(111, 38);
            this.ProductBtn.TabIndex = 43;
            this.ProductBtn.Text = "Products";
            this.ProductBtn.UseVisualStyleBackColor = false;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // SallerBtn
            // 
            this.SallerBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SallerBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SallerBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.SallerBtn.Location = new System.Drawing.Point(34, 143);
            this.SallerBtn.Name = "SallerBtn";
            this.SallerBtn.Size = new System.Drawing.Size(83, 38);
            this.SallerBtn.TabIndex = 42;
            this.SallerBtn.Text = "Seller";
            this.SallerBtn.UseVisualStyleBackColor = false;
            this.SallerBtn.Click += new System.EventHandler(this.SallerBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(1318, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.Datelbl.ForeColor = System.Drawing.Color.White;
            this.Datelbl.Location = new System.Drawing.Point(1060, 25);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(47, 19);
            this.Datelbl.TabIndex = 25;
            this.Datelbl.Tag = "";
            this.Datelbl.Text = "Date";
            // 
            // CatDGV
            // 
            this.CatDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatDGV.BackgroundColor = System.Drawing.Color.White;
            this.CatDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CatDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.CatDGV.GridColor = System.Drawing.SystemColors.GrayText;
            this.CatDGV.Location = new System.Drawing.Point(554, 96);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CatDGV.RowHeadersVisible = false;
            this.CatDGV.RowHeadersWidth = 51;
            this.CatDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.CatDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.CatDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CatDGV.RowTemplate.Height = 29;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(634, 542);
            this.CatDGV.TabIndex = 19;
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.SystemColors.Control;
            this.Deletebtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.Deletebtn.Location = new System.Drawing.Point(291, 337);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 40);
            this.Deletebtn.TabIndex = 18;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.EditBtn.Location = new System.Drawing.Point(165, 337);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(94, 40);
            this.EditBtn.TabIndex = 17;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CatAddBtn
            // 
            this.CatAddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CatAddBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatAddBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.CatAddBtn.Location = new System.Drawing.Point(38, 337);
            this.CatAddBtn.Name = "CatAddBtn";
            this.CatAddBtn.Size = new System.Drawing.Size(94, 40);
            this.CatAddBtn.TabIndex = 16;
            this.CatAddBtn.Text = "ADD";
            this.CatAddBtn.UseVisualStyleBackColor = false;
            this.CatAddBtn.Click += new System.EventHandler(this.CatAddBtn_Click);
            // 
            // CatDescTxt
            // 
            this.CatDescTxt.BackColor = System.Drawing.Color.White;
            this.CatDescTxt.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDescTxt.Location = new System.Drawing.Point(165, 220);
            this.CatDescTxt.Name = "CatDescTxt";
            this.CatDescTxt.Size = new System.Drawing.Size(220, 34);
            this.CatDescTxt.TabIndex = 4;
            this.CatDescTxt.Text = "";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(20, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "DISCRIPTION";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CatNameTxt
            // 
            this.CatNameTxt.BackColor = System.Drawing.Color.White;
            this.CatNameTxt.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTxt.Location = new System.Drawing.Point(165, 156);
            this.CatNameTxt.Name = "CatNameTxt";
            this.CatNameTxt.Size = new System.Drawing.Size(220, 34);
            this.CatNameTxt.TabIndex = 4;
            this.CatNameTxt.Text = "";
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
            // CatidTxt
            // 
            this.CatidTxt.BackColor = System.Drawing.Color.White;
            this.CatidTxt.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatidTxt.Location = new System.Drawing.Point(165, 100);
            this.CatidTxt.Name = "CatidTxt";
            this.CatidTxt.Size = new System.Drawing.Size(220, 34);
            this.CatidTxt.TabIndex = 4;
            this.CatidTxt.Text = "";
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
            this.label4.Location = new System.Drawing.Point(375, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "MANAGE CATEGORIES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.CatDGV);
            this.panel1.Controls.Add(this.Deletebtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.CatAddBtn);
            this.panel1.Controls.Add(this.CatDescTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CatNameTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CatidTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(147, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 671);
            this.panel1.TabIndex = 40;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 728);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ProductBtn);
            this.Controls.Add(this.SallerBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogoutBtn;
        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.Button SallerBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.DataGridView CatDGV;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button CatAddBtn;
        private System.Windows.Forms.RichTextBox CatDescTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox CatNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox CatidTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}