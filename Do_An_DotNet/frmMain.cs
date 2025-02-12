using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_DotNet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadForm(new UC_Home()); // Mặc định hiển thị UC_Home
        }
        private void LoadForm(UserControl userControl)
        {
            pnlContent.Controls.Clear(); // Xóa nội dung cũ
            userControl.Dock = DockStyle.Fill; // Lấp đầy panelContent
            pnlContent.Controls.Add(userControl); // Thêm UC mới vào panelContent
        }
        private void btn_nhanVien_Click(object sender, EventArgs e)
        {
            
            if (maCV == 2) // Nếu là nhân viên
            {
                MessageBox.Show("Không được phép truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng luôn sự kiện, không cho mở quản lý nhân viên
            }

            // Nếu là admin, tiếp tục mở giao diện quản lý nhân viên
            pnlContent.Controls.Clear();
            UC_NhanVien ucNhanVien = new UC_NhanVien(pnlContent);
            pnlContent.Controls.Add(ucNhanVien);
            ucNhanVien.Dock = DockStyle.Fill;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            LoadForm(new UC_Home());
        }

        private void btn_khachHang_Click(object sender, EventArgs e)
        {
            LoadForm(new UC_KhachHang());
        }

        private void btn_sanPham_Click(object sender, EventArgs e)
        {
            LoadForm(new UC_SanPham());
        }
        private void btn_NhaPP_Click(object sender, EventArgs e)
        {
            LoadForm(new UC_NhaCC());
        }

        private void btn_donHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_giaoDich_Click(object sender, EventArgs e)
        {

        }

        private void btn_doanhThu_Click(object sender, EventArgs e)
        {

        }


        private bool isLoggingOut = false; // Biến cờ kiểm tra đăng xuất
        // ---- Phân quyền
        private int maCV; // Lưu quyền của người dùng
        private string tenTaiKhoan; // Lưu tên tài khoản
        public frmMain(int maCV ,string tenTaiKhoan) // Nhận MA_CV từ frmDangNhap
        {
            InitializeComponent();
            this.maCV = maCV;
            this.tenTaiKhoan = tenTaiKhoan;
            HienThiTaiKhoan();
            PhanQuyenNguoiDung();
        }
        private void PhanQuyenNguoiDung()
        {
            if (maCV == 2) // Nếu là nhân viên
            {
                List<string> chucNangBiChan = new List<string> {
            "btn_QuanLyNhanVien",
            "btn_QuanLyDoanhThu"
        };

                foreach (Control ctrl in pnlMenu.Controls)
                {
                    if (ctrl is Button btn && chucNangBiChan.Contains(btn.Name))
                    {
                        btn.Click += ChucNangBiChan;
                        btn.Enabled = false; // Vô hiệu hóa nút luôn
                    }
                }
            }
        }
        private void ChucNangBiChan(object sender, EventArgs e)
        {
            MessageBox.Show("Không được phép truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void HienThiTaiKhoan()
        {
            lbl_vaiTro.Text = $"{tenTaiKhoan}"; // Cập nhật nhãn
        }
        // Đăng xuất
        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn đăng xuất?",
        "Xác nhận",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                isLoggingOut = true; // Đánh dấu đang đăng xuất
                this.Hide(); // Ẩn frmMain
                frmDangNhap loginForm = new frmDangNhap();
                loginForm.ShowDialog(); // Chờ đăng nhập lại
                this.Close(); // Đóng frmMain
            }
        }
        // Đóng form
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu đang đăng xuất, bỏ qua hộp thoại xác nhận thoát ứng dụng
            if (isLoggingOut) return;

            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát ứng dụng không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy việc đóng form nếu chọn "No"
            }
            else
            {
                isLoggingOut = true; // Đánh dấu đang thoát ứng dụng
                Application.ExitThread(); // Đóng toàn bộ ứng dụng
            }
        }
    }
}
