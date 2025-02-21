namespace Do_An_DotNet
{
    partial class UC_NhapTTGiaoDich
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbo_sanPham = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericSL = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.rtb_chungTu = new System.Windows.Forms.RichTextBox();
            this.btn_luuPN = new System.Windows.Forms.Button();
            this.cbo_nhanVien = new System.Windows.Forms.ComboBox();
            this.cbo_NSX = new System.Windows.Forms.ComboBox();
            this.txt_thueVAT = new System.Windows.Forms.TextBox();
            this.txt_tongTienPN = new System.Windows.Forms.TextBox();
            this.dtp_ngayLapPN = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_luuPC = new System.Windows.Forms.Button();
            this.rtb_dienGiai = new System.Windows.Forms.RichTextBox();
            this.txt_soTienTT = new System.Windows.Forms.TextBox();
            this.dtp_ngayLapPC = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericSL)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_sanPham
            // 
            this.cbo_sanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_sanPham.FormattingEnabled = true;
            this.cbo_sanPham.Location = new System.Drawing.Point(630, 230);
            this.cbo_sanPham.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_sanPham.Name = "cbo_sanPham";
            this.cbo_sanPham.Size = new System.Drawing.Size(180, 32);
            this.cbo_sanPham.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(468, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Sản Phẩm";
            // 
            // numericSL
            // 
            this.numericSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSL.Location = new System.Drawing.Point(630, 174);
            this.numericSL.Margin = new System.Windows.Forms.Padding(2);
            this.numericSL.Name = "numericSL";
            this.numericSL.Size = new System.Drawing.Size(180, 29);
            this.numericSL.TabIndex = 14;
            this.numericSL.ValueChanged += new System.EventHandler(this.numericSL_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(468, 177);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Số Lượng";
            // 
            // rtb_chungTu
            // 
            this.rtb_chungTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_chungTu.Location = new System.Drawing.Point(191, 227);
            this.rtb_chungTu.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_chungTu.Name = "rtb_chungTu";
            this.rtb_chungTu.Size = new System.Drawing.Size(273, 131);
            this.rtb_chungTu.TabIndex = 12;
            this.rtb_chungTu.Text = "";
            // 
            // btn_luuPN
            // 
            this.btn_luuPN.Image = global::Do_An_DotNet.Properties.Resources.diskette__1_;
            this.btn_luuPN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luuPN.Location = new System.Drawing.Point(630, 317);
            this.btn_luuPN.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luuPN.Name = "btn_luuPN";
            this.btn_luuPN.Size = new System.Drawing.Size(180, 41);
            this.btn_luuPN.TabIndex = 11;
            this.btn_luuPN.Text = "Lưu phiếu nhập";
            this.btn_luuPN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_luuPN.UseVisualStyleBackColor = true;
            this.btn_luuPN.Click += new System.EventHandler(this.btn_luuPN_Click);
            // 
            // cbo_nhanVien
            // 
            this.cbo_nhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_nhanVien.FormattingEnabled = true;
            this.cbo_nhanVien.Location = new System.Drawing.Point(630, 127);
            this.cbo_nhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_nhanVien.Name = "cbo_nhanVien";
            this.cbo_nhanVien.Size = new System.Drawing.Size(180, 32);
            this.cbo_nhanVien.TabIndex = 10;
            // 
            // cbo_NSX
            // 
            this.cbo_NSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_NSX.FormattingEnabled = true;
            this.cbo_NSX.Location = new System.Drawing.Point(630, 79);
            this.cbo_NSX.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_NSX.Name = "cbo_NSX";
            this.cbo_NSX.Size = new System.Drawing.Size(180, 32);
            this.cbo_NSX.TabIndex = 9;
            // 
            // txt_thueVAT
            // 
            this.txt_thueVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thueVAT.Location = new System.Drawing.Point(191, 171);
            this.txt_thueVAT.Margin = new System.Windows.Forms.Padding(2);
            this.txt_thueVAT.Name = "txt_thueVAT";
            this.txt_thueVAT.Size = new System.Drawing.Size(196, 29);
            this.txt_thueVAT.TabIndex = 6;
            // 
            // txt_tongTienPN
            // 
            this.txt_tongTienPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongTienPN.Location = new System.Drawing.Point(191, 121);
            this.txt_tongTienPN.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tongTienPN.Name = "txt_tongTienPN";
            this.txt_tongTienPN.Size = new System.Drawing.Size(196, 29);
            this.txt_tongTienPN.TabIndex = 7;
            // 
            // dtp_ngayLapPN
            // 
            this.dtp_ngayLapPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayLapPN.Location = new System.Drawing.Point(191, 75);
            this.dtp_ngayLapPN.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngayLapPN.Name = "dtp_ngayLapPN";
            this.dtp_ngayLapPN.Size = new System.Drawing.Size(196, 29);
            this.dtp_ngayLapPN.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(468, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nhân viên nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(468, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nhà Sản Xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Lập Phiếu Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng Tiên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Chứng Từ Góc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thuế VAT";
            // 
            // btn_luuPC
            // 
            this.btn_luuPC.Image = global::Do_An_DotNet.Properties.Resources.diskette__1_;
            this.btn_luuPC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luuPC.Location = new System.Drawing.Point(639, 215);
            this.btn_luuPC.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luuPC.Name = "btn_luuPC";
            this.btn_luuPC.Size = new System.Drawing.Size(171, 38);
            this.btn_luuPC.TabIndex = 6;
            this.btn_luuPC.Text = "Lưu phiếu chi";
            this.btn_luuPC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_luuPC.UseVisualStyleBackColor = true;
            this.btn_luuPC.Click += new System.EventHandler(this.btn_luuPC_Click);
            // 
            // rtb_dienGiai
            // 
            this.rtb_dienGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_dienGiai.Location = new System.Drawing.Point(210, 128);
            this.rtb_dienGiai.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_dienGiai.Name = "rtb_dienGiai";
            this.rtb_dienGiai.Size = new System.Drawing.Size(594, 66);
            this.rtb_dienGiai.TabIndex = 5;
            this.rtb_dienGiai.Text = "";
            // 
            // txt_soTienTT
            // 
            this.txt_soTienTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soTienTT.Location = new System.Drawing.Point(210, 77);
            this.txt_soTienTT.Margin = new System.Windows.Forms.Padding(2);
            this.txt_soTienTT.Name = "txt_soTienTT";
            this.txt_soTienTT.Size = new System.Drawing.Size(297, 29);
            this.txt_soTienTT.TabIndex = 4;
            // 
            // dtp_ngayLapPC
            // 
            this.dtp_ngayLapPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayLapPC.Location = new System.Drawing.Point(210, 38);
            this.dtp_ngayLapPC.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngayLapPC.Name = "dtp_ngayLapPC";
            this.dtp_ngayLapPC.Size = new System.Drawing.Size(297, 29);
            this.dtp_ngayLapPC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diễn Giải";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Tiền Thanh Toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Lập Phiếu Chi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_sanPham);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numericSL);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.rtb_chungTu);
            this.groupBox2.Controls.Add(this.btn_luuPN);
            this.groupBox2.Controls.Add(this.cbo_nhanVien);
            this.groupBox2.Controls.Add(this.cbo_NSX);
            this.groupBox2.Controls.Add(this.txt_thueVAT);
            this.groupBox2.Controls.Add(this.txt_tongTienPN);
            this.groupBox2.Controls.Add(this.dtp_ngayLapPN);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(39, 363);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(822, 373);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu Nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_luuPC);
            this.groupBox1.Controls.Add(this.rtb_dienGiai);
            this.groupBox1.Controls.Add(this.txt_soTienTT);
            this.groupBox1.Controls.Add(this.dtp_ngayLapPC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(822, 275);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Chi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(256, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(422, 31);
            this.label12.TabIndex = 7;
            this.label12.Text = "NHẬP THÔNG TIN GIAO DỊCH";
            // 
            // UC_NhapTTGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_NhapTTGiaoDich";
            this.Size = new System.Drawing.Size(900, 761);
            ((System.ComponentModel.ISupportInitialize)(this.numericSL)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_sanPham;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericSL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtb_chungTu;
        private System.Windows.Forms.Button btn_luuPN;
        private System.Windows.Forms.ComboBox cbo_nhanVien;
        private System.Windows.Forms.ComboBox cbo_NSX;
        private System.Windows.Forms.TextBox txt_thueVAT;
        private System.Windows.Forms.TextBox txt_tongTienPN;
        private System.Windows.Forms.DateTimePicker dtp_ngayLapPN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_luuPC;
        private System.Windows.Forms.RichTextBox rtb_dienGiai;
        private System.Windows.Forms.TextBox txt_soTienTT;
        private System.Windows.Forms.DateTimePicker dtp_ngayLapPC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
    }
}
