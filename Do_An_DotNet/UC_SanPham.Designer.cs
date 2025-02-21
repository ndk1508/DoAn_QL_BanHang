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
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.btn_suaSP = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(294, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_XoaSP);
            this.groupBox1.Controls.Add(this.btn_suaSP);
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
            // btn_XoaSP
            // 
            this.btn_XoaSP.ForeColor = System.Drawing.Color.Red;
            this.btn_XoaSP.Image = global::Do_An_DotNet.Properties.Resources.delete__1_;
            this.btn_XoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaSP.Location = new System.Drawing.Point(397, 608);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(142, 42);
            this.btn_XoaSP.TabIndex = 6;
            this.btn_XoaSP.Text = "Xoá";
            this.btn_XoaSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XoaSP.UseVisualStyleBackColor = true;
            this.btn_XoaSP.Click += new System.EventHandler(this.btn_XoaSP_Click);
            // 
            // btn_suaSP
            // 
            this.btn_suaSP.Image = global::Do_An_DotNet.Properties.Resources.service__1_;
            this.btn_suaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suaSP.Location = new System.Drawing.Point(717, 611);
            this.btn_suaSP.Name = "btn_suaSP";
            this.btn_suaSP.Size = new System.Drawing.Size(163, 39);
            this.btn_suaSP.TabIndex = 5;
            this.btn_suaSP.Text = "Sửa sản phẩm";
            this.btn_suaSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_suaSP.UseVisualStyleBackColor = true;
            this.btn_suaSP.Click += new System.EventHandler(this.btn_suaSP_Click);
            // 
            // btn_themSP
            // 
            this.btn_themSP.Image = global::Do_An_DotNet.Properties.Resources.add__1_;
            this.btn_themSP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themSP.Location = new System.Drawing.Point(545, 608);
            this.btn_themSP.Name = "btn_themSP";
            this.btn_themSP.Size = new System.Drawing.Size(166, 44);
            this.btn_themSP.TabIndex = 3;
            this.btn_themSP.Text = "Thêm sản phẩm";
            this.btn_themSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_themSP.UseVisualStyleBackColor = true;
            this.btn_themSP.Click += new System.EventHandler(this.btn_themSP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm:";
            // 
            // txt_timKiemSP
            // 
            this.txt_timKiemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timKiemSP.Location = new System.Drawing.Point(157, 26);
            this.txt_timKiemSP.Name = "txt_timKiemSP";
            this.txt_timKiemSP.Size = new System.Drawing.Size(308, 31);
            this.txt_timKiemSP.TabIndex = 1;
            this.txt_timKiemSP.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // dgv_danhsachSP
            // 
            this.dgv_danhsachSP.AllowUserToAddRows = false;
            this.dgv_danhsachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachSP.Location = new System.Drawing.Point(6, 74);
            this.dgv_danhsachSP.Name = "dgv_danhsachSP";
            this.dgv_danhsachSP.Size = new System.Drawing.Size(874, 511);
            this.dgv_danhsachSP.TabIndex = 0;
            this.dgv_danhsachSP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachSP_CellDoubleClick);
            this.dgv_danhsachSP.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachSP_CellEndEdit);
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
        private System.Windows.Forms.Button btn_suaSP;
        private System.Windows.Forms.Button btn_themSP;
        private System.Windows.Forms.Button btn_XoaSP;
    }
}
