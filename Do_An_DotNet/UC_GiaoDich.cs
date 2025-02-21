using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Do_An_DotNet
{
    public partial class UC_GiaoDich : UserControl
    {
        private Panel pnlContent; // Biến để lưu Panel chính từ frmMain
        private string connectionString = "Data Source=DESKTOP-N5BJBSG;Initial Catalog=QL_BanHang;Integrated Security=True;Encrypt=False;";
        public UC_GiaoDich(Panel contentPanel)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.pnlContent = contentPanel; // Nhận panel từ frmMain
            LoadPhieuNhap();
            LoadPhieuChi();
        }
        private void LoadPhieuNhap()
        {
            string query = "SELECT STT_PN, NGAYLAP_PN, TONGTIEN_PN, CHUNGTUGOC_PN, TONGTIENTHUEGTGT FROM PHIEUNHAPHANG";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_phieuNhap.DataSource = dt;
                // Cài đặt độ rộng cột
                dgv_phieuNhap.Columns["STT_PN"].Width = 80; // Cột họ tên rộng hơn
                dgv_phieuNhap.Columns["NGAYLAP_PN"].Width = 160;
                dgv_phieuNhap.Columns["TONGTIEN_PN"].Width = 180;
                dgv_phieuNhap.Columns["CHUNGTUGOC_PN"].Width = 175;
                dgv_phieuNhap.Columns["TONGTIENTHUEGTGT"].Width = 160;
            }
        }
        private void LoadPhieuChi()
        {
            string query = "SELECT STT_PC, NGAYLAP_PC, SOTIENTHANHTOAN_PC, DIENGIAI_PC FROM PHIEUCHI";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_phieuChi.DataSource = dt;
                // Cài đặt độ rộng cột
                dgv_phieuChi.Columns["STT_PC"].Width = 80; // Cột họ tên rộng hơn
                dgv_phieuChi.Columns["NGAYLAP_PC"].Width = 180;
                dgv_phieuChi.Columns["SOTIENTHANHTOAN_PC"].Width = 200;
                dgv_phieuChi.Columns["DIENGIAI_PC"].Width = 300;
            }
        }

        private void btn_nhapThongtin_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear(); // Xóa nội dung cũ
            UC_NhapTTGiaoDich themThongTin = new UC_NhapTTGiaoDich(pnlContent);
            pnlContent.Controls.Add(themThongTin); // Thêm UserControl mới vào
            themThongTin.Dock = DockStyle.Fill;
        }
    }
}
