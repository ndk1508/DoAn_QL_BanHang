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
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=MAY30;Initial Catalog=QL_BanHang;Integrated Security=True";
        private string maKH = ""; // Biến lưu mã khách hàng được chọn


        // ----------------DANH SÁCH KHÁCH HÀNG
        private void LoadDanhSachKhachHang(string tuKhoa = "")
        {
            string query = "SELECT MA_KH, HOTEN_KH, SDT_KH, EMAIL_KH, DIACHI_KH FROM KHACH_HANG";

            if (!string.IsNullOrWhiteSpace(tuKhoa)) // Nếu có từ khóa, tìm kiếm
            {
                query += " WHERE HOTEN_KH LIKE @TuKhoa OR SDT_KH LIKE @TuKhoa OR EMAIL_KH LIKE @TuKhoa";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(tuKhoa))
                    {
                        cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%"); // Tìm kiếm gần đúng
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv_khachHang.DataSource = dt;
                    }
                }
            }   
        }
        private void UC_KhachHang_Load_1(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
        }

        // SỬA KHÁCH HÀNG

        private void dgv_khachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không chọn dòng tiêu đề
            {
                DataGridViewRow row = dgv_khachHang.Rows[e.RowIndex];

                maKH = row.Cells["MA_KH"].Value.ToString();
                txt_hoTenKH.Text = row.Cells["HOTEN_KH"].Value.ToString();
                txt_sdtKH.Text = row.Cells["SDT_KH"].Value.ToString();
                txt_emailKH.Text = row.Cells["EMAIL_KH"].Value.ToString();
                txt_diaChiKH.Text = row.Cells["DIACHI_KH"].Value.ToString();
            }

        }

        private void btn_suaKhachHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hộp thoại xác nhận trước khi sửa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa thông tin khách hàng không?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Hủy sửa nếu chọn "No"
            }

            string query = "UPDATE KHACH_HANG SET HOTEN_KH = @HoTen, NGAYSINH_KH = @NgaySinh, DIACHI_KH = @DiaChi, SDT_KH = @SDT, EMAIL_KH = @Email WHERE MA_KH = @MaKH";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@HoTen", txt_hoTenKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgaySinh", dtp_ngaySinhKH.Value);
                    cmd.Parameters.AddWithValue("@DiaChi", txt_diaChiKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@SDT", txt_sdtKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txt_emailKH.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachKhachHang(); // Cập nhật lại danh sách khách hàng
                        LamMoiThongTinKhachHang(); // Xóa thông tin sau khi cập nhật
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // -------------- THÊM KHÁCH HÀNG
   
        private void ThemKhachHang()
        {
            if (string.IsNullOrWhiteSpace(txt_hoTenKH.Text) || string.IsNullOrWhiteSpace(txt_sdtKH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO KHACH_HANG (HOTEN_KH, NGAYSINH_KH, DIACHI_KH, SDT_KH, EMAIL_KH) " +
                           "VALUES (@HOTEN_KH, @NGAYSINH_KH, @DIACHI_KH, @SDT_KH, @EMAIL_KH)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HOTEN_KH", txt_hoTenKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@NGAYSINH_KH", dtp_ngaySinhKH.Value);
                    cmd.Parameters.AddWithValue("@DIACHI_KH", txt_diaChiKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@SDT_KH", txt_sdtKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@EMAIL_KH", txt_emailKH.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachKhachHang(); // Cập nhật lại danh sách khách hàng
                        LamMoiThongTinKhachHang(); // Xóa thông tin sau khi lưu
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btn_themkhachHang_Click(object sender, EventArgs e)
        {
            ThemKhachHang();
        }
        private void LamMoiThongTinKhachHang()
        {
            txt_hoTenKH.Clear();
            txt_sdtKH.Clear();
            txt_emailKH.Clear();
            txt_diaChiKH.Clear();
            dtp_ngaySinhKH.Value = DateTime.Now; // Reset ngày sinh về hiện tại
        }

        private void btn_grb2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;  // Hiện GroupBox2 khi bấm nút "Thêm khách hàng"
        }

        private void btn_hiengrb2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;  // Hiện GroupBox2 khi bấm nút "Sửa khách hàng"
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang(txt_timKiem.Text.Trim());
        }
    }
}
