namespace Do_An_DotNet
{
    partial class UC_GiaoDich
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
            this.btn_nhapThongtin = new System.Windows.Forms.Button();
            this.dgv_phieuNhap = new System.Windows.Forms.DataGridView();
            this.dgv_phieuChi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuChi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_nhapThongtin
            // 
            this.btn_nhapThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapThongtin.Image = global::Do_An_DotNet.Properties.Resources.add__1_;
            this.btn_nhapThongtin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nhapThongtin.Location = new System.Drawing.Point(682, 685);
            this.btn_nhapThongtin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nhapThongtin.Name = "btn_nhapThongtin";
            this.btn_nhapThongtin.Size = new System.Drawing.Size(174, 47);
            this.btn_nhapThongtin.TabIndex = 11;
            this.btn_nhapThongtin.Text = "Nhập Thông Tin";
            this.btn_nhapThongtin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nhapThongtin.UseVisualStyleBackColor = true;
            this.btn_nhapThongtin.Click += new System.EventHandler(this.btn_nhapThongtin_Click);
            // 
            // dgv_phieuNhap
            // 
            this.dgv_phieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieuNhap.Location = new System.Drawing.Point(5, 24);
            this.dgv_phieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_phieuNhap.Name = "dgv_phieuNhap";
            this.dgv_phieuNhap.RowHeadersWidth = 51;
            this.dgv_phieuNhap.RowTemplate.Height = 24;
            this.dgv_phieuNhap.Size = new System.Drawing.Size(818, 276);
            this.dgv_phieuNhap.TabIndex = 10;
            // 
            // dgv_phieuChi
            // 
            this.dgv_phieuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieuChi.Location = new System.Drawing.Point(10, 24);
            this.dgv_phieuChi.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_phieuChi.Name = "dgv_phieuChi";
            this.dgv_phieuChi.RowHeadersWidth = 51;
            this.dgv_phieuChi.RowTemplate.Height = 24;
            this.dgv_phieuChi.Size = new System.Drawing.Size(813, 235);
            this.dgv_phieuChi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ GIAO DỊCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_phieuChi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 264);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu chi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_phieuNhap);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 305);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu nhập";
            // 
            // UC_GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_nhapThongtin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_GiaoDich";
            this.Size = new System.Drawing.Size(900, 761);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuChi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nhapThongtin;
        private System.Windows.Forms.DataGridView dgv_phieuNhap;
        private System.Windows.Forms.DataGridView dgv_phieuChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
