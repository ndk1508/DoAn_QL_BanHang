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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-N5BJBSG;Initial Catalog=QL_BanHang;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MA_CV, TENTAIKHOAN FROM NHANVIEN WHERE TENTAIKHOAN = @TaiKhoan AND MATKHAU = @MatKhau";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", txt_loginName.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txt_Password.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int maCV = reader.GetInt32(0); // Lấy MA_CV
                            string tenTaiKhoan = reader.GetString(1); // Lấy TENTAIKHOAN

                            // Xác định vai trò và hiển thị thông báo
                            string role = (maCV == 1) ? "ADMIN" : "NHÂN VIÊN";
                            MessageBox.Show($"Đăng nhập thành công với tư cách {role}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide(); // Ẩn form đăng nhập
                            frmMain mainForm = new frmMain(maCV, tenTaiKhoan); // Truyền mã chức vụ và tên tài khoản
                            mainForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

    }
}
