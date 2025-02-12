namespace Do_An_DotNet
{
    partial class UC_NhanVien
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
            this.btn_dangKy = new System.Windows.Forms.Button();
            this.btn_suaNhanvien = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_xoaNhanvien = new System.Windows.Forms.Button();
            this.grb_dsNV = new System.Windows.Forms.GroupBox();
            this.btn_timKiem = new System.Windows.Forms.Label();
            this.dgv_QLNhanvien = new System.Windows.Forms.DataGridView();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.grb_dsNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btn_dangKy
            // 
            this.btn_dangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangKy.Location = new System.Drawing.Point(54, 693);
            this.btn_dangKy.Name = "btn_dangKy";
            this.btn_dangKy.Size = new System.Drawing.Size(147, 41);
            this.btn_dangKy.TabIndex = 1;
            this.btn_dangKy.Text = "Thêm nhân viên";
            this.btn_dangKy.UseVisualStyleBackColor = true;
            this.btn_dangKy.Click += new System.EventHandler(this.btn_dangKy_Click);
            // 
            // btn_suaNhanvien
            // 
            this.btn_suaNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suaNhanvien.Location = new System.Drawing.Point(249, 693);
            this.btn_suaNhanvien.Name = "btn_suaNhanvien";
            this.btn_suaNhanvien.Size = new System.Drawing.Size(147, 41);
            this.btn_suaNhanvien.TabIndex = 4;
            this.btn_suaNhanvien.Text = "Sửa";
            this.btn_suaNhanvien.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(699, 693);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(147, 41);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_xoaNhanvien
            // 
            this.btn_xoaNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaNhanvien.Location = new System.Drawing.Point(478, 693);
            this.btn_xoaNhanvien.Name = "btn_xoaNhanvien";
            this.btn_xoaNhanvien.Size = new System.Drawing.Size(147, 41);
            this.btn_xoaNhanvien.TabIndex = 6;
            this.btn_xoaNhanvien.Text = "Xóa";
            this.btn_xoaNhanvien.UseVisualStyleBackColor = true;
            this.btn_xoaNhanvien.Click += new System.EventHandler(this.btn_xoaNhanvien_Click);
            // 
            // grb_dsNV
            // 
            this.grb_dsNV.Controls.Add(this.btn_timKiem);
            this.grb_dsNV.Controls.Add(this.dgv_QLNhanvien);
            this.grb_dsNV.Controls.Add(this.txt_timKiem);
            this.grb_dsNV.Controls.Add(this.btn_lamMoi);
            this.grb_dsNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_dsNV.Location = new System.Drawing.Point(46, 124);
            this.grb_dsNV.Name = "grb_dsNV";
            this.grb_dsNV.Size = new System.Drawing.Size(800, 516);
            this.grb_dsNV.TabIndex = 7;
            this.grb_dsNV.TabStop = false;
            this.grb_dsNV.Text = "Danh sách nhân viên";
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.AutoSize = true;
            this.btn_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.Location = new System.Drawing.Point(51, 37);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(75, 20);
            this.btn_timKiem.TabIndex = 11;
            this.btn_timKiem.Text = "Tìm kiếm:";
            // 
            // dgv_QLNhanvien
            // 
            this.dgv_QLNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLNhanvien.Location = new System.Drawing.Point(6, 80);
            this.dgv_QLNhanvien.Name = "dgv_QLNhanvien";
            this.dgv_QLNhanvien.Size = new System.Drawing.Size(788, 430);
            this.dgv_QLNhanvien.TabIndex = 10;
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timKiem.Location = new System.Drawing.Point(132, 34);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(293, 26);
            this.txt_timKiem.TabIndex = 9;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamMoi.Location = new System.Drawing.Point(647, 27);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(147, 41);
            this.btn_lamMoi.TabIndex = 8;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click_1);
            // 
            // UC_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.grb_dsNV);
            this.Controls.Add(this.btn_xoaNhanvien);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_suaNhanvien);
            this.Controls.Add(this.btn_dangKy);
            this.Controls.Add(this.label1);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(892, 761);
            this.Load += new System.EventHandler(this.UC_NhanVien_Load_1);
            this.grb_dsNV.ResumeLayout(false);
            this.grb_dsNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dangKy;
        private System.Windows.Forms.Button btn_suaNhanvien;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_xoaNhanvien;
        private System.Windows.Forms.GroupBox grb_dsNV;
        private System.Windows.Forms.Label btn_timKiem;
        private System.Windows.Forms.DataGridView dgv_QLNhanvien;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.Button btn_lamMoi;
    }
}
