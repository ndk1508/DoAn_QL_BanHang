namespace Do_An_DotNet
{
    partial class frmDangNhap
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
            this.lbl_DangNhap = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_loginName = new System.Windows.Forms.Label();
            this.txt_loginName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DangNhap
            // 
            this.lbl_DangNhap.AutoSize = true;
            this.lbl_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DangNhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_DangNhap.Location = new System.Drawing.Point(284, 29);
            this.lbl_DangNhap.Name = "lbl_DangNhap";
            this.lbl_DangNhap.Size = new System.Drawing.Size(187, 33);
            this.lbl_DangNhap.TabIndex = 2;
            this.lbl_DangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(242, 163);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(83, 21);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Mật khẩu:";
            // 
            // lbl_loginName
            // 
            this.lbl_loginName.AutoSize = true;
            this.lbl_loginName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginName.Location = new System.Drawing.Point(242, 115);
            this.lbl_loginName.Name = "lbl_loginName";
            this.lbl_loginName.Size = new System.Drawing.Size(125, 21);
            this.lbl_loginName.TabIndex = 4;
            this.lbl_loginName.Text = "Tên đăng nhập:";
            // 
            // txt_loginName
            // 
            this.txt_loginName.Location = new System.Drawing.Point(387, 114);
            this.txt_loginName.Name = "txt_loginName";
            this.txt_loginName.Size = new System.Drawing.Size(291, 26);
            this.txt_loginName.TabIndex = 5;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(387, 160);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(291, 26);
            this.txt_Password.TabIndex = 6;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(387, 235);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(118, 33);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Do_An_DotNet.Properties.Resources.Conan;
            this.pictureBox1.Location = new System.Drawing.Point(21, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_loginName);
            this.Controls.Add(this.lbl_loginName);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_DangNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_DangNhap;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_loginName;
        private System.Windows.Forms.TextBox txt_loginName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}