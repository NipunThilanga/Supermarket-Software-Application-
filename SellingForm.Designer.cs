namespace Splash
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SellerNamelbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ORDERDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.AddproductBtn = new System.Windows.Forms.Button();
            this.ProdQty = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BillID = new System.Windows.Forms.RichTextBox();
            this.ProdPrice = new System.Windows.Forms.RichTextBox();
            this.ProdDGV1 = new System.Windows.Forms.DataGridView();
            this.Datelbl = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.AddsellsBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LogoutLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Amtlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.DeleteBtn.Location = new System.Drawing.Point(995, 636);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 40);
            this.DeleteBtn.TabIndex = 37;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SellerNamelbl
            // 
            this.SellerNamelbl.AutoSize = true;
            this.SellerNamelbl.BackColor = System.Drawing.Color.DarkOrange;
            this.SellerNamelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerNamelbl.ForeColor = System.Drawing.Color.White;
            this.SellerNamelbl.Location = new System.Drawing.Point(20, 8);
            this.SellerNamelbl.Name = "SellerNamelbl";
            this.SellerNamelbl.Size = new System.Drawing.Size(62, 23);
            this.SellerNamelbl.TabIndex = 36;
            this.SellerNamelbl.Text = "Seller";
            this.SellerNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkOrange;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(760, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 38);
            this.label8.TabIndex = 35;
            this.label8.Text = "SELLS LIST";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ORDERDGV
            // 
            this.ORDERDGV.AllowUserToResizeColumns = false;
            this.ORDERDGV.AllowUserToResizeRows = false;
            this.ORDERDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ORDERDGV.BackgroundColor = System.Drawing.Color.White;
            this.ORDERDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ORDERDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ORDERDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ORDERDGV.ColumnHeadersHeight = 29;
            this.ORDERDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ORDERDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ORDERDGV.Location = new System.Drawing.Point(492, 76);
            this.ORDERDGV.Name = "ORDERDGV";
            this.ORDERDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkOrange;
            this.ORDERDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ORDERDGV.RowHeadersVisible = false;
            this.ORDERDGV.RowHeadersWidth = 51;
            this.ORDERDGV.RowTemplate.Height = 29;
            this.ORDERDGV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ORDERDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ORDERDGV.Size = new System.Drawing.Size(657, 187);
            this.ORDERDGV.TabIndex = 34;
            // 
            // id
            // 
            this.id.HeaderText = "ProdID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(728, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 36);
            this.label3.TabIndex = 32;
            this.label3.Text = "Amount ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddproductBtn
            // 
            this.AddproductBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddproductBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddproductBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.AddproductBtn.Location = new System.Drawing.Point(24, 298);
            this.AddproductBtn.Name = "AddproductBtn";
            this.AddproductBtn.Size = new System.Drawing.Size(174, 40);
            this.AddproductBtn.TabIndex = 31;
            this.AddproductBtn.Text = "Add Product";
            this.AddproductBtn.UseVisualStyleBackColor = false;
            this.AddproductBtn.Click += new System.EventHandler(this.AddproductBtn_Click);
            // 
            // ProdQty
            // 
            this.ProdQty.BackColor = System.Drawing.Color.White;
            this.ProdQty.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQty.Location = new System.Drawing.Point(195, 231);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(217, 28);
            this.ProdQty.TabIndex = 30;
            this.ProdQty.Text = "";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkOrange;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(20, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 38);
            this.label6.TabIndex = 29;
            this.label6.Text = "QUANTITY";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BillID
            // 
            this.BillID.BackColor = System.Drawing.Color.White;
            this.BillID.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillID.Location = new System.Drawing.Point(195, 76);
            this.BillID.Name = "BillID";
            this.BillID.Size = new System.Drawing.Size(217, 28);
            this.BillID.TabIndex = 28;
            this.BillID.Text = "";
            // 
            // ProdPrice
            // 
            this.ProdPrice.BackColor = System.Drawing.Color.White;
            this.ProdPrice.Enabled = false;
            this.ProdPrice.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice.Location = new System.Drawing.Point(195, 182);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(217, 28);
            this.ProdPrice.TabIndex = 27;
            this.ProdPrice.Text = "";
            // 
            // ProdDGV1
            // 
            this.ProdDGV1.AllowUserToResizeColumns = false;
            this.ProdDGV1.AllowUserToResizeRows = false;
            this.ProdDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdDGV1.BackgroundColor = System.Drawing.Color.White;
            this.ProdDGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProdDGV1.ColumnHeadersHeight = 29;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDGV1.DefaultCellStyle = dataGridViewCellStyle5;
            this.ProdDGV1.Location = new System.Drawing.Point(24, 368);
            this.ProdDGV1.Name = "ProdDGV1";
            this.ProdDGV1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ProdDGV1.RowHeadersVisible = false;
            this.ProdDGV1.RowHeadersWidth = 51;
            this.ProdDGV1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProdDGV1.RowTemplate.Height = 29;
            this.ProdDGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV1.Size = new System.Drawing.Size(332, 325);
            this.ProdDGV1.TabIndex = 24;
            this.ProdDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV1_CellContentClick);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.Datelbl.ForeColor = System.Drawing.Color.White;
            this.Datelbl.Location = new System.Drawing.Point(1102, 17);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(47, 19);
            this.Datelbl.TabIndex = 23;
            this.Datelbl.Tag = "";
            this.Datelbl.Text = "Date";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RefreshBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.RefreshBtn.Location = new System.Drawing.Point(253, 298);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(115, 40);
            this.RefreshBtn.TabIndex = 21;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // BillsDGV
            // 
            this.BillsDGV.AllowUserToResizeColumns = false;
            this.BillsDGV.AllowUserToResizeRows = false;
            this.BillsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillsDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.BillsDGV.ColumnHeadersHeight = 29;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillsDGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.BillsDGV.Location = new System.Drawing.Point(500, 409);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillsDGV.RowHeadersVisible = false;
            this.BillsDGV.RowHeadersWidth = 51;
            this.BillsDGV.RowTemplate.Height = 29;
            this.BillsDGV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsDGV.Size = new System.Drawing.Size(672, 212);
            this.BillsDGV.TabIndex = 21;
            this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.SystemColors.Control;
            this.PrintBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.PrintBtn.Location = new System.Drawing.Point(818, 636);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(94, 40);
            this.PrintBtn.TabIndex = 17;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // AddsellsBtn
            // 
            this.AddsellsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddsellsBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddsellsBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.AddsellsBtn.Location = new System.Drawing.Point(654, 636);
            this.AddsellsBtn.Name = "AddsellsBtn";
            this.AddsellsBtn.Size = new System.Drawing.Size(94, 40);
            this.AddsellsBtn.TabIndex = 16;
            this.AddsellsBtn.Text = "ADD";
            this.AddsellsBtn.UseVisualStyleBackColor = false;
            this.AddsellsBtn.Click += new System.EventHandler(this.AddsellsBtn_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(20, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "PRICE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.White;
            this.ProdName.Enabled = false;
            this.ProdName.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.Location = new System.Drawing.Point(195, 126);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(217, 28);
            this.ProdName.TabIndex = 4;
            this.ProdName.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "BILL ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(512, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "SELLING";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoutLbl
            // 
            this.LogoutLbl.AutoSize = true;
            this.LogoutLbl.BackColor = System.Drawing.SystemColors.Control;
            this.LogoutLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.LogoutLbl.Location = new System.Drawing.Point(25, 711);
            this.LogoutLbl.Name = "LogoutLbl";
            this.LogoutLbl.Size = new System.Drawing.Size(76, 23);
            this.LogoutLbl.TabIndex = 40;
            this.LogoutLbl.Text = "Logout";
            this.LogoutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogoutLbl.Click += new System.EventHandler(this.LogoutLbl_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(1313, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(20, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "PORDUCT NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.SellerNamelbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ORDERDGV);
            this.panel1.Controls.Add(this.Amtlbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddproductBtn);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BillID);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.ProdDGV1);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.BillsDGV);
            this.panel1.Controls.Add(this.PrintBtn);
            this.panel1.Controls.Add(this.AddsellsBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(142, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 706);
            this.panel1.TabIndex = 38;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Amtlbl
            // 
            this.Amtlbl.BackColor = System.Drawing.Color.DarkOrange;
            this.Amtlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amtlbl.ForeColor = System.Drawing.Color.White;
            this.Amtlbl.Location = new System.Drawing.Point(843, 285);
            this.Amtlbl.Name = "Amtlbl";
            this.Amtlbl.Size = new System.Drawing.Size(107, 36);
            this.Amtlbl.TabIndex = 33;
            this.Amtlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 759);
            this.Controls.Add(this.LogoutLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label SellerNamelbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ORDERDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddproductBtn;
        private System.Windows.Forms.RichTextBox ProdQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox BillID;
        private System.Windows.Forms.RichTextBox ProdPrice;
        private System.Windows.Forms.DataGridView ProdDGV1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.DataGridView BillsDGV;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button AddsellsBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LogoutLbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Amtlbl;
    }
}