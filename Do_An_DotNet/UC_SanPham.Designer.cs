namespace Do_An_DotNet
{
    partial class UC_SanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_suaSP = new System.Windows.Forms.Button();
            this.btn_xoaSP = new System.Windows.Forms.Button();
            this.btn_themSP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_timKiemSP = new System.Windows.Forms.TextBox();
            this.dgv_danhsachSP = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btn_suaSP);
            this.groupBox1.Controls.Add(this.btn_xoaSP);
            this.groupBox1.Controls.Add(this.btn_themSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_timKiemSP);
            this.groupBox1.Controls.Add(this.dgv_danhsachSP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 663);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(762, 604);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 36);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_suaSP
            // 
            this.btn_suaSP.Location = new System.Drawing.Point(574, 603);
            this.btn_suaSP.Name = "btn_suaSP";
            this.btn_suaSP.Size = new System.Drawing.Size(129, 37);
            this.btn_suaSP.TabIndex = 5;
            this.btn_suaSP.Text = "Sửa sản phẩm";
            this.btn_suaSP.UseVisualStyleBackColor = true;
            // 
            // btn_xoaSP
            // 
            this.btn_xoaSP.Location = new System.Drawing.Point(258, 602);
            this.btn_xoaSP.Name = "btn_xoaSP";
            this.btn_xoaSP.Size = new System.Drawing.Size(96, 38);
            this.btn_xoaSP.TabIndex = 4;
            this.btn_xoaSP.Text = "Xóa";
            this.btn_xoaSP.UseVisualStyleBackColor = true;
            this.btn_xoaSP.Click += new System.EventHandler(this.btn_xoaSP_Click);
            // 
            // btn_themSP
            // 
            this.btn_themSP.Location = new System.Drawing.Point(35, 602);
            this.btn_themSP.Name = "btn_themSP";
            this.btn_themSP.Size = new System.Drawing.Size(149, 38);
            this.btn_themSP.TabIndex = 3;
            this.btn_themSP.Text = "Thêm sản phẩm";
            this.btn_themSP.UseVisualStyleBackColor = true;
            this.btn_themSP.Click += new System.EventHandler(this.btn_themSP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm:";
            // 
            // txt_timKiemSP
            // 
            this.txt_timKiemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timKiemSP.Location = new System.Drawing.Point(157, 26);
            this.txt_timKiemSP.Name = "txt_timKiemSP";
            this.txt_timKiemSP.Size = new System.Drawing.Size(308, 26);
            this.txt_timKiemSP.TabIndex = 1;
            this.txt_timKiemSP.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // dgv_danhsachSP
            // 
            this.dgv_danhsachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachSP.Location = new System.Drawing.Point(6, 58);
            this.dgv_danhsachSP.Name = "dgv_danhsachSP";
            this.dgv_danhsachSP.Size = new System.Drawing.Size(874, 527);
            this.dgv_danhsachSP.TabIndex = 0;
            // 
            // UC_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_SanPham";
            this.Size = new System.Drawing.Size(892, 761);
            this.Load += new System.EventHandler(this.UC_SanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_timKiemSP;
        private System.Windows.Forms.DataGridView dgv_danhsachSP;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_suaSP;
        private System.Windows.Forms.Button btn_xoaSP;
        private System.Windows.Forms.Button btn_themSP;
    }
}
