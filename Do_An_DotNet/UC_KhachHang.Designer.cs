namespace Do_An_DotNet
{
    partial class UC_KhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themkhachHang = new System.Windows.Forms.Button();
            this.btn_suaKhachHang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_timkiemKhachhang = new System.Windows.Forms.Button();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_khachHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_ngaySinhKH = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_emailKH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_diaChiKH = new System.Windows.Forms.TextBox();
            this.txt_sdtKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hoTenKH = new System.Windows.Forms.TextBox();
            this.btn_grb2 = new System.Windows.Forms.Button();
            this.btn_hiengrb2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // btn_themkhachHang
            // 
            this.btn_themkhachHang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_themkhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themkhachHang.ForeColor = System.Drawing.Color.OldLace;
            this.btn_themkhachHang.Location = new System.Drawing.Point(669, 224);
            this.btn_themkhachHang.Name = "btn_themkhachHang";
            this.btn_themkhachHang.Size = new System.Drawing.Size(118, 34);
            this.btn_themkhachHang.TabIndex = 1;
            this.btn_themkhachHang.Text = "Thêm";
            this.btn_themkhachHang.UseVisualStyleBackColor = false;
            this.btn_themkhachHang.Click += new System.EventHandler(this.btn_themkhachHang_Click);
            // 
            // btn_suaKhachHang
            // 
            this.btn_suaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suaKhachHang.ForeColor = System.Drawing.Color.Red;
            this.btn_suaKhachHang.Location = new System.Drawing.Point(526, 224);
            this.btn_suaKhachHang.Name = "btn_suaKhachHang";
            this.btn_suaKhachHang.Size = new System.Drawing.Size(118, 34);
            this.btn_suaKhachHang.TabIndex = 4;
            this.btn_suaKhachHang.Text = "Sửa";
            this.btn_suaKhachHang.UseVisualStyleBackColor = true;
            this.btn_suaKhachHang.Click += new System.EventHandler(this.btn_suaKhachHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_hiengrb2);
            this.groupBox1.Controls.Add(this.btn_grb2);
            this.groupBox1.Controls.Add(this.btn_timkiemKhachhang);
            this.groupBox1.Controls.Add(this.txt_timKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgv_khachHang);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 355);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // btn_timkiemKhachhang
            // 
            this.btn_timkiemKhachhang.Image = global::Do_An_DotNet.Properties.Resources.pngtree_vector_search_icon_png_image_966647;
            this.btn_timkiemKhachhang.Location = new System.Drawing.Point(456, 41);
            this.btn_timkiemKhachhang.Name = "btn_timkiemKhachhang";
            this.btn_timkiemKhachhang.Size = new System.Drawing.Size(85, 26);
            this.btn_timkiemKhachhang.TabIndex = 5;
            this.btn_timkiemKhachhang.UseVisualStyleBackColor = true;
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timKiem.Location = new System.Drawing.Point(92, 41);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(358, 26);
            this.txt_timKiem.TabIndex = 4;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm:";
            // 
            // dgv_khachHang
            // 
            this.dgv_khachHang.AllowUserToAddRows = false;
            this.dgv_khachHang.AllowUserToResizeRows = false;
            this.dgv_khachHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_khachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachHang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_khachHang.Location = new System.Drawing.Point(12, 82);
            this.dgv_khachHang.Name = "dgv_khachHang";
            this.dgv_khachHang.Size = new System.Drawing.Size(815, 203);
            this.dgv_khachHang.TabIndex = 2;
            this.dgv_khachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khachHang_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_ngaySinhKH);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_emailKH);
            this.groupBox2.Controls.Add(this.btn_themkhachHang);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btn_suaKhachHang);
            this.groupBox2.Controls.Add(this.txt_diaChiKH);
            this.groupBox2.Controls.Add(this.txt_sdtKH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_hoTenKH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 474);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 274);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÊM KHÁCH HÀNG";
            this.groupBox2.Visible = false;
            // 
            // dtp_ngaySinhKH
            // 
            this.dtp_ngaySinhKH.Location = new System.Drawing.Point(154, 177);
            this.dtp_ngaySinhKH.Name = "dtp_ngaySinhKH";
            this.dtp_ngaySinhKH.Size = new System.Drawing.Size(374, 31);
            this.dtp_ngaySinhKH.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ngày sinh:";
            // 
            // txt_emailKH
            // 
            this.txt_emailKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailKH.Location = new System.Drawing.Point(526, 61);
            this.txt_emailKH.Name = "txt_emailKH";
            this.txt_emailKH.Size = new System.Drawing.Size(261, 26);
            this.txt_emailKH.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(430, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Email:";
            // 
            // txt_diaChiKH
            // 
            this.txt_diaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaChiKH.Location = new System.Drawing.Point(154, 117);
            this.txt_diaChiKH.Name = "txt_diaChiKH";
            this.txt_diaChiKH.Size = new System.Drawing.Size(261, 26);
            this.txt_diaChiKH.TabIndex = 15;
            // 
            // txt_sdtKH
            // 
            this.txt_sdtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdtKH.Location = new System.Drawing.Point(526, 117);
            this.txt_sdtKH.Name = "txt_sdtKH";
            this.txt_sdtKH.Size = new System.Drawing.Size(261, 26);
            this.txt_sdtKH.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "SDT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Họ tên:";
            // 
            // txt_hoTenKH
            // 
            this.txt_hoTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoTenKH.Location = new System.Drawing.Point(154, 61);
            this.txt_hoTenKH.Name = "txt_hoTenKH";
            this.txt_hoTenKH.Size = new System.Drawing.Size(261, 26);
            this.txt_hoTenKH.TabIndex = 11;
            // 
            // btn_grb2
            // 
            this.btn_grb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grb2.Location = new System.Drawing.Point(465, 303);
            this.btn_grb2.Name = "btn_grb2";
            this.btn_grb2.Size = new System.Drawing.Size(178, 34);
            this.btn_grb2.TabIndex = 6;
            this.btn_grb2.Text = "Thêm khách hàng";
            this.btn_grb2.UseVisualStyleBackColor = true;
            this.btn_grb2.Click += new System.EventHandler(this.btn_grb2_Click);
            // 
            // btn_hiengrb2
            // 
            this.btn_hiengrb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hiengrb2.Location = new System.Drawing.Point(649, 303);
            this.btn_hiengrb2.Name = "btn_hiengrb2";
            this.btn_hiengrb2.Size = new System.Drawing.Size(178, 34);
            this.btn_hiengrb2.TabIndex = 7;
            this.btn_hiengrb2.Text = "Sửa khách hàng";
            this.btn_hiengrb2.UseVisualStyleBackColor = true;
            this.btn_hiengrb2.Click += new System.EventHandler(this.btn_hiengrb2_Click);
            // 
            // UC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(892, 761);
            this.Load += new System.EventHandler(this.UC_KhachHang_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_themkhachHang;
        private System.Windows.Forms.Button btn_suaKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_timkiemKhachhang;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_khachHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_emailKH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_diaChiKH;
        private System.Windows.Forms.TextBox txt_sdtKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_hoTenKH;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinhKH;
        private System.Windows.Forms.Button btn_grb2;
        private System.Windows.Forms.Button btn_hiengrb2;
    }
}
