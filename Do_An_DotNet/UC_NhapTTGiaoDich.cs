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
    public partial class UC_NhapTTGiaoDich : UserControl
    {
        private string connectionString = "Data Source=DESKTOP-N5BJBSG;Initial Catalog=QL_BanHang;Integrated Security=True;Encrypt=False;";
        private Panel pnlContent;
        public UC_NhapTTGiaoDich(Panel contentPanel)
        {
            InitializeComponent();
            this.pnlContent = contentPanel;
            LoadNhanVien();
            LoadNhaSanXuat();
            LoadSanPham();
        }
        private void LoadNhanVien()
        {
            try
            {
                string query = "SELECT MA_NV, HOTEN_NV FROM NHANVIEN";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbo_nhanVien.DataSource = dt;
                    cbo_nhanVien.DisplayMember = "HOTEN_NV";
                    cbo_nhanVien.ValueMember = "MA_NV";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message);
            }
        }
        private void LoadNhaSanXuat()
        {
            try
            {
                string query = "SELECT MA_NSX, TEN_NSX FROM NHA_SAN_XUAT";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbo_NSX.DataSource = dt;
                    cbo_NSX.DisplayMember = "TEN_NSX";
                    cbo_NSX.ValueMember = "MA_NSX";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhà sản xuất: " + ex.Message);
            }
        }

        private void btn_luuPC_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_soTienTT.Text))
                {
                    MessageBox.Show("Vui lòng nhập số tiền thanh toán.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO PHIEUCHI (NGAYLAP_PC, SOTIENTHANHTOAN_PC, MA_NV, MA_NSX, DIENGIAI_PC)
                VALUES (@NGAYLAP_PC, @SOTIENTHANHTOAN_PC, @MA_NV, @MA_NSX, @DIENGIAI_PC)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NGAYLAP_PC", dtp_ngayLapPC.Value);
                        cmd.Parameters.AddWithValue("@SOTIENTHANHTOAN_PC", Convert.ToDecimal(txt_soTienTT.Text));
                        cmd.Parameters.AddWithValue("@MA_NV", cbo_nhanVien.SelectedValue);
                        cmd.Parameters.AddWithValue("@MA_NSX", cbo_NSX.SelectedValue);
                        cmd.Parameters.AddWithValue("@DIENGIAI_PC", rtb_dienGiai.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm phiếu chi thành công!");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số tiền thanh toán không hợp lệ. Vui lòng nhập lại.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu chi: " + ex.Message);
            }
        }
        private void LoadSanPham()
        {
            try
            {
                // Lấy cột MA_SANPHAM, TEN_SANPHAM (và có thể GIA_SANPHAM nếu cần)
                string query = "SELECT MA_SANPHAM, TEN_SANPHAM FROM SANPHAM";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Gán DataSource cho comboBox
                    cbo_sanPham.DataSource = dt;
                    cbo_sanPham.DisplayMember = "TEN_SANPHAM";   // Tên hiển thị
                    cbo_sanPham.ValueMember = "MA_SANPHAM";      // Giá trị ẩn = mã sp
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message);
            }
        }
        private void btn_luuPN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_tongTienPN.Text) ||
                    string.IsNullOrWhiteSpace(txt_thueVAT.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu nhập hàng.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO PHIEUNHAPHANG (MA_SANPHAM,TONGTIEN_PN, TONGTIENTHUEGTGT,CHUNGTUGOC_PN, MA_NV, NGAYLAP_PN)
                VALUES (@MA_SANPHAM, @TONGTIEN_PN, @TONGTIENTHUEGTGT,@CHUNGTUGOC_PN,@MA_NV, @NGAYLAP_PN)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MA_SANPHAM", cbo_sanPham.SelectedValue?.ToString() ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@TONGTIEN_PN", Convert.ToDecimal(txt_tongTienPN.Text));
                        cmd.Parameters.AddWithValue("@TONGTIENTHUEGTGT", Convert.ToDecimal(txt_thueVAT.Text));
                        cmd.Parameters.AddWithValue("@CHUNGTUGOC_PN", rtb_chungTu.Text);
                        cmd.Parameters.AddWithValue("@MA_NV", cbo_nhanVien.SelectedValue);
                        cmd.Parameters.AddWithValue("@NGAYLAP_PN", dtp_ngayLapPN.Value);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm phiếu nhập thành công!");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng kiểm tra lại.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu nhập hàng: " + ex.Message);
            }
        }

        private void numericSL_ValueChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (cbo_sanPham.SelectedValue != null)
                {
                    int maSanPham = Convert.ToInt32(cbo_sanPham.SelectedValue);
                    string query = "SELECT GIA_SANPHAM FROM SANPHAM WHERE MA_SANPHAM = @MA_SANPHAM";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MA_SANPHAM", maSanPham);
                    conn.Open();
                    double giaSanPham = Convert.ToDouble(cmd.ExecuteScalar());
                    conn.Close();

                    int soLuong = (int)numericSL.Value;
                    double vat = giaSanPham * soLuong * 0.1;
                    double tongGiaTri = (giaSanPham * soLuong) + vat;

                    txt_thueVAT.Text = vat.ToString("N2");
                    txt_tongTienPN.Text = tongGiaTri.ToString("N2");
                }
            }
        }
    }
}

