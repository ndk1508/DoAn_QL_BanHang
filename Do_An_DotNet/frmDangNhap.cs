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
            string connectionString = "Data Source=MAY30;Initial Catalog=QL_BanHang;Integrated Security=True";

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
                            int maCV = reader.GetInt32(0);
                            string tenTaiKhoan = reader.GetString(1);

                            MessageBox.Show($"Đăng nhập thành công với tư cách {(maCV == 1 ? "ADMIN" : "NHÂN VIÊN")}!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide(); // Ẩn frmDangNhap
                            frmMain mainForm = new frmMain(maCV, tenTaiKhoan);
                            mainForm.ShowDialog(); // Mở frmMain, dùng ShowDialog để khi đóng sẽ quay lại login
                            this.Show(); // Hiển thị lại frmDangNhap khi frmMain đóng
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
