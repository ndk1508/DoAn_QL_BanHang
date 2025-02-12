using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_DotNet
{
    public partial class UC_DangKyNV : UserControl
    {
        private Panel pnlContent; // Lưu trữ panel chính
        public UC_DangKyNV(Panel contentPanel)
        {
            InitializeComponent();
            this.pnlContent = contentPanel; // Nhận panel từ frmMain
        }
        private void LuuThongTinNhanVien()
        {
            try
            {
                // Kiểm tra dữ liệu trước khi lưu
                if (string.IsNullOrWhiteSpace(txt_taiKhoanNV.Text) || string.IsNullOrWhiteSpace(txt_matKhauNV.Text))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(txt_cccdNV.Text, out _) || txt_cccdNV.Text.Length != 12)
                {
                    MessageBox.Show("Số CCCD không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(txt_sdtNV.Text, out _) || txt_sdtNV.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Data Source=DESKTOP-N5BJBSG;Initial Catalog=QL_BanHang;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO NHANVIEN (TENTAIKHOAN, MATKHAU, MA_CV, SOCCCD, HOTEN_NV, GIOITINH, SDT_NV, EMAIL_NV, DIACHI_NV) " +
                                   "VALUES (@TENTAIKHOAN, @MATKHAU, @MA_CV, @SOCCCD, @HOTEN_NV, @GIOITINH, @SDT_NV, @EMAIL_NV, @DIACHI_NV)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        string gioiTinh = cbo_gioiTinhNV.SelectedItem?.ToString() ?? "Không xác định";
                        object maChucVu = cbo_chucVu.SelectedValue ?? 2; // Giả sử mặc định là 2 (Nhân viên)
                        


                        cmd.Parameters.AddWithValue("@TENTAIKHOAN", txt_taiKhoanNV.Text.Trim());
                        cmd.Parameters.AddWithValue("@MATKHAU", txt_matKhauNV.Text.Trim());
                        cmd.Parameters.AddWithValue("@MA_CV", maChucVu);
                        cmd.Parameters.AddWithValue("@SOCCCD", txt_cccdNV.Text.Trim());
                        cmd.Parameters.AddWithValue("@HOTEN_NV", txt_hoTenNV.Text.Trim());
                        cmd.Parameters.AddWithValue("@GIOITINH", gioiTinh);
                        cmd.Parameters.AddWithValue("@SDT_NV", txt_sdtNV.Text.Trim());
                        cmd.Parameters.AddWithValue("@EMAIL_NV", txt_emailNV.Text.Trim());
                        cmd.Parameters.AddWithValue("@DIACHI_NV", txt_diaChiNV.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Lưu thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            LuuThongTinNhanVien();
        }

        private void btn_troVe_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear(); // Xóa nội dung hiện tại
            UC_NhanVien ucNhanVien = new UC_NhanVien(pnlContent);
            pnlContent.Controls.Add(ucNhanVien); // Thêm UC_NhanVien vào panel
            ucNhanVien.Dock = DockStyle.Fill;
        }
    }
}
