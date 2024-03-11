namespace Splash
{
    partial class Loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearLbl = new System.Windows.Forms.Label();
            this.RoleCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.PasswordTxt = new System.Windows.Forms.RichTextBox();
            this.UsernameTxt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(796, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(115, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 34);
            this.label7.TabIndex = 26;
            this.label7.Text = "APPLICATION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkOrange;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 34);
            this.label6.TabIndex = 25;
            this.label6.Text = "SUPERMARKET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(115, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 34);
            this.label5.TabIndex = 24;
            this.label5.Text = "WELCOME";
            // 
            // ClearLbl
            // 
            this.ClearLbl.AutoSize = true;
            this.ClearLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.ClearLbl.Location = new System.Drawing.Point(614, 441);
            this.ClearLbl.Name = "ClearLbl";
            this.ClearLbl.Size = new System.Drawing.Size(53, 19);
            this.ClearLbl.TabIndex = 23;
            this.ClearLbl.Text = "Clear";
            this.ClearLbl.Click += new System.EventHandler(this.ClearLbl_Click);
            // 
            // RoleCb
            // 
            this.RoleCb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleCb.ForeColor = System.Drawing.Color.DarkOrange;
            this.RoleCb.FormattingEnabled = true;
            this.RoleCb.Items.AddRange(new object[] {
            "ADMIN",
            "SALLER"});
            this.RoleCb.Location = new System.Drawing.Point(508, 143);
            this.RoleCb.Name = "RoleCb";
            this.RoleCb.Size = new System.Drawing.Size(264, 29);
            this.RoleCb.TabIndex = 22;
            this.RoleCb.Text = "Seelct Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(370, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(370, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "USERNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(605, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Login";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.LoginBtn.Location = new System.Drawing.Point(551, 388);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(187, 37);
            this.LoginBtn.TabIndex = 18;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox3.BackColor = System.Drawing.Color.DarkOrange;
            this.richTextBox3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(-1, -1);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(334, 496);
            this.richTextBox3.TabIndex = 17;
            this.richTextBox3.Text = "";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.Color.DarkOrange;
            this.PasswordTxt.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(508, 303);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(264, 37);
            this.PasswordTxt.TabIndex = 16;
            this.PasswordTxt.Text = "";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BackColor = System.Drawing.Color.DarkOrange;
            this.UsernameTxt.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(508, 213);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(264, 34);
            this.UsernameTxt.TabIndex = 15;
            this.UsernameTxt.Text = "";
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClearLbl);
            this.Controls.Add(this.RoleCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginform";
            this.Load += new System.EventHandler(this.Loginform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ClearLbl;
        private System.Windows.Forms.ComboBox RoleCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox PasswordTxt;
        private System.Windows.Forms.RichTextBox UsernameTxt;
    }
}