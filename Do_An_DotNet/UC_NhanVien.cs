using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_DotNet
{
    public partial class UC_NhanVien : UserControl
    {
        private Panel pnlContent; // Biến để lưu Panel chính từ frmMain
        private string connectionString = "Data Source=MAY30;Initial Catalog=QL_BanHang;Integrated Security=True";
        private Dictionary<string, Dictionary<string, string>> danhSachSua = new Dictionary<string, Dictionary<string, string>>();// sửa nhân viên

        public UC_NhanVien(Panel contentPanel)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.pnlContent = contentPanel; // Nhận panel từ frmMain
        }
        // Phương thức load danh sách nhân viên
        private void LoadDanhSachNhanVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MA_NV, HOTEN_NV , TENTAIKHOAN, GIOITINH, SDT_NV, EMAIL_NV ,MA_CV FROM NHANVIEN";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgv_QLNhanvien.DataSource = dt; // Gán dữ liệu vào DataGridView

                        // Cài đặt độ rộng cột
                        dgv_QLNhanvien.Columns["HOTEN_NV"].Width = 160; // Cột họ tên rộng hơn
                        dgv_QLNhanvien.Columns["MA_NV"].Width = 60; 
                        dgv_QLNhanvien.Columns["GIOITINH"].Width = 80;
                        dgv_QLNhanvien.Columns["MA_CV"].Width = 60;
                        dgv_QLNhanvien.Columns["EMAIL_NV"].Width = 145;
                        dgv_QLNhanvien.Columns["TENTAIKHOAN"].Width = 140;
                        // Kiểm tra nếu bảng trống
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không có dữ liệu nhân viên trong CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UC_NhanVien_Load_1(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien(); // Gọi phương thức khi UserControl được load
        }
        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear(); // Xóa nội dung cũ
            UC_DangKyNV dangKyNhanVien = new UC_DangKyNV(pnlContent);
            pnlContent.Controls.Add(dangKyNhanVien); // Thêm UserControl mới vào
            dangKyNhanVien.Dock = DockStyle.Fill;
        }

        private void btn_lamMoi_Click_1(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien(); // Tải lại danh sách nhân viên
        }

        private void btn_xoaNhanvien_Click(object sender, EventArgs e)
        {
            if (dgv_QLNhanvien.CurrentRow != null) // Kiểm tra dòng hiện tại
            {
                int maNV;
                if (int.TryParse(dgv_QLNhanvien.CurrentRow.Cells["MA_NV"].Value.ToString(), out maNV))
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?",
                                                          "Xác nhận xóa",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "DELETE FROM NHANVIEN WHERE MA_NV = @MA_NV"; // Đổi MANV thành MA_NV

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@MA_NV", maNV);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachNhanVien(); // Cập nhật lại danh sách
                    }
                }
                else
                {
                    MessageBox.Show("Không thể lấy mã nhân viên! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // SỬA NHÂN VIÊN
        private void dgv_QLNhanvien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_QLNhanvien.Rows[e.RowIndex];
                string maNV = row.Cells["MA_NV"].Value.ToString(); // Lấy mã nhân viên

                // Lưu lại thông tin chỉnh sửa vào danhSachSua
                if (!danhSachSua.ContainsKey(maNV))
                {
                    danhSachSua[maNV] = new Dictionary<string, string>();
                }

                string columnName = dgv_QLNhanvien.Columns[e.ColumnIndex].Name; // Lấy tên cột chỉnh sửa
                string newValue = row.Cells[e.ColumnIndex].Value.ToString(); // Lấy giá trị mới

                danhSachSua[maNV][columnName] = newValue;
            }
        }
        private void btn_suaNhanvien_Click(object sender, EventArgs e)
        {
            if (danhSachSua.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nào thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (var nv in danhSachSua)
                {
                    string maNV = nv.Key; // Mã nhân viên cần sửa
                    Dictionary<string, string> changes = nv.Value; // Các giá trị đã sửa

                    List<string> setClauses = new List<string>();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    foreach (var change in changes)
                    {
                        string column = change.Key;
                        string value = change.Value;

                        setClauses.Add($"{column} = @{column}");
                        cmd.Parameters.AddWithValue($"@{column}", value);
                    }

                    if (setClauses.Count > 0)
                    {
                        string query = $"UPDATE NHANVIEN SET {string.Join(", ", setClauses)} WHERE MA_NV = @MaNV";
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@MaNV", maNV);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Cập nhật nhân viên {maNV} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Cập nhật nhân viên {maNV} thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            danhSachSua.Clear(); // Xóa danh sách sau khi cập nhật
            LoadDanhSachNhanVien(); // Load lại danh sách nhân viên
        }
        // TÌM KIẾM NV
        private void TimKiemNhanVien(string tuKhoa)
        {
            // Kiểm tra nếu DataGridView đã có dữ liệu
            if (dgv_QLNhanvien.DataSource is DataTable dt)
            {
                // Sử dụng DataView để lọc dữ liệu
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("TENTAIKHOAN LIKE '%{0}%' OR HOTEN_NV LIKE '%{0}%' OR SDT_NV LIKE '%{0}%' OR EMAIL_NV LIKE '%{0}%'", tuKhoa);
            }
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemNhanVien(txt_timKiem.Text.Trim());
        }
    }
}

