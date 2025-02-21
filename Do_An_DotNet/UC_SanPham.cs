using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_DotNet
{
    public partial class UC_SanPham : UserControl
    {
        private Panel pnlContent; // Biến để lưu Panel chính từ frmMain
        private string connectionString = "Data Source=DESKTOP-N5BJBSG;Initial Catalog=QL_BanHang;Integrated Security=True";
        private Dictionary<int, Dictionary<string, object>> danhSachSua = new Dictionary<int, Dictionary<string, object>>();

        public UC_SanPham(Panel contentPanel)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.pnlContent = contentPanel;// Gán panel được truyền vào
            LoadSanPham();

        }
        private void LoadSanPham(string tuKhoa = "")
        {
            string query = @"SELECT MA_SANPHAM, ANH_SANPHAM, TEN_SANPHAM, LOAI_SANPHAM.TEN_LOAI AS LOAI_SANPHAM,GIA_SANPHAM, MOTA_SANPHAM, NGAYCAPPHAT_SANPHAM, SOLUONGTON_SANPHAM, CONGDUNG_SANPHAM 
                             FROM SANPHAM
                             LEFT JOIN LOAI_SANPHAM ON SANPHAM.MA_LOAI = LOAI_SANPHAM.MA_LOAI";

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                query += " WHERE CAST(MA_SANPHAM AS NVARCHAR) LIKE @TuKhoa OR TEN_SANPHAM LIKE @TuKhoa OR LOAI_SANPHAM.TEN_LOAI LIKE @TuKhoa";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(tuKhoa))
                    {
                        cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgv_danhsachSP.AutoGenerateColumns = true;
                        dgv_danhsachSP.Columns.Clear();
                        dgv_danhsachSP.DataSource = dt;

                        if (dgv_danhsachSP.Columns["ANH_SANPHAM"] is DataGridViewImageColumn imgColumn)
                        {
                            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            imgColumn.Width = 150;
                        }
                        dgv_danhsachSP.RowTemplate.Height = 150;

                        dgv_danhsachSP.Columns["ANH_SANPHAM"].HeaderText = "Hình Ảnh";
                        dgv_danhsachSP.Columns["MA_SANPHAM"].HeaderText = "Mã Sản Phẩm";
                        dgv_danhsachSP.Columns["TEN_SANPHAM"].HeaderText = "Tên Sản Phẩm";
                        dgv_danhsachSP.Columns["LOAI_SANPHAM"].HeaderText = "Loại Sản Phẩm";
                        dgv_danhsachSP.Columns["GIA_SANPHAM"].HeaderText = " Giá sản phẩm";
                        dgv_danhsachSP.Columns["MOTA_SANPHAM"].HeaderText = "Mô Tả";
                        dgv_danhsachSP.Columns["NGAYCAPPHAT_SANPHAM"].HeaderText = "Ngày Cập Nhật";
                        dgv_danhsachSP.Columns["SOLUONGTON_SANPHAM"].HeaderText = "Số Lượng Tồn";
                        dgv_danhsachSP.Columns["CONGDUNG_SANPHAM"].HeaderText = "Công Dụng";

                        foreach (DataGridViewColumn column in dgv_danhsachSP.Columns)
                        {
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
            }
        }

        private void btn_themSP_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear(); // Xóa nội dung cũ
            UC_ThemSanPham themSanPham = new UC_ThemSanPham(pnlContent); // Tạo UC_ThemSanPham
            pnlContent.Controls.Add(themSanPham); // Thêm UserControl vào panel
            themSanPham.Dock = DockStyle.Fill; // Dock để full panel
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            LoadSanPham(txt_timKiemSP.Text.Trim());
        }

        private void dgv_danhsachSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_danhsachSP.Rows[e.RowIndex];
                string chiTiet = $"Mã: {row.Cells["MA_SANPHAM"].Value}\nTên: {row.Cells["TEN_SANPHAM"].Value}\nLoại: {row.Cells["LOAI_SANPHAM"].Value}\nMô tả: {row.Cells["MOTA_SANPHAM"].Value}\nNgày cập nhật: {row.Cells["NGAYCAPPHAT_SANPHAM"].Value}\nSố lượng: {row.Cells["SOLUONGTON_SANPHAM"].Value}\nCông dụng: {row.Cells["CONGDUNG_SANPHAM"].Value}";
                MessageBox.Show(chiTiet, "Chi Tiết Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        //SỬA SẢN PHẨM

        private void dgv_danhsachSP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_danhsachSP.Rows[e.RowIndex];
                int maSP = Convert.ToInt32(row.Cells["MA_SANPHAM"].Value); // Lấy mã sản phẩm

                // Nếu mã sản phẩm chưa có trong danh sách sửa, thêm mới
                if (!danhSachSua.ContainsKey(maSP))
                {
                    danhSachSua[maSP] = new Dictionary<string, object>();
                }

                string columnName = dgv_danhsachSP.Columns[e.ColumnIndex].Name; // Lấy tên cột sửa
                object newValue = row.Cells[e.ColumnIndex].Value; // Giá trị mới

                danhSachSua[maSP][columnName] = newValue; // Lưu vào danh sách sửa
            }
        }
        private void btn_suaSP_Click(object sender, EventArgs e)
        {
            if (danhSachSua.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nào thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (var sp in danhSachSua)
                {
                    int maSP = sp.Key; // Mã sản phẩm cần sửa
                    Dictionary<string, object> changes = sp.Value; // Các giá trị đã sửa

                    List<string> setClauses = new List<string>();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    foreach (var change in changes)
                    {
                        string column = change.Key;
                        object value = change.Value ?? DBNull.Value;

                        setClauses.Add($"{column} = @{column}");
                        cmd.Parameters.AddWithValue($"@{column}", value);
                    }

                    if (setClauses.Count > 0)
                    {
                        string query = $"UPDATE SANPHAM SET {string.Join(", ", setClauses)} WHERE MA_SANPHAM = @MaSP";
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@MaSP", maSP);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Cập nhật sản phẩm {maSP} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Cập nhật sản phẩm {maSP} thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            danhSachSua.Clear(); // Xóa danh sách sau khi cập nhật
            LoadSanPham(); // Load lại danh sách sản phẩm
        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            if (dgv_danhsachSP.CurrentRow != null) // Kiểm tra dòng hiện tại
            {
                int inmaSP;
                if (int.TryParse(dgv_danhsachSP.CurrentRow.Cells["MA_SANPHAM"].Value.ToString(), out inmaSP))
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này cùng với phiếu nhập, hóa đơn, phiếu chi liên quan?",
                                                          "Xác nhận xóa",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            SqlTransaction transaction = conn.BeginTransaction(); // Bắt đầu transaction

                            try
                            {
                                // 1. Xóa dữ liệu trong PHIEUNHAPHANG liên quan đến sản phẩm này
                                string queryDeletePhieuNhap = "DELETE FROM PHIEUNHAPHANG WHERE MA_SANPHAM = @MA_SANPHAM";
                                using (SqlCommand cmd = new SqlCommand(queryDeletePhieuNhap, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@MA_SANPHAM", inmaSP);
                                    cmd.ExecuteNonQuery();
                                }

                                // 2. Xóa dữ liệu trong PHIEUCHI liên quan đến NSX của sản phẩm này
                                string queryDeletePhieuChi = @"
                            DELETE FROM PHIEUCHI 
                            WHERE MA_NSX IN 
                            (SELECT MA_NSX FROM NHA_SAN_XUAT WHERE MA_TH IN 
                            (SELECT MA_TH FROM THUONGHIEU WHERE MA_SANPHAM = @MA_SANPHAM))";
                                using (SqlCommand cmd = new SqlCommand(queryDeletePhieuChi, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@MA_SANPHAM", inmaSP);
                                    cmd.ExecuteNonQuery();
                                }

                                // 3. Xóa dữ liệu trong NHA_SAN_XUAT
                                string queryDeleteNSX = @"
                            DELETE FROM NHA_SAN_XUAT 
                            WHERE MA_TH IN 
                            (SELECT MA_TH FROM THUONGHIEU WHERE MA_SANPHAM = @MA_SANPHAM)";
                                using (SqlCommand cmd = new SqlCommand(queryDeleteNSX, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@MA_SANPHAM", inmaSP);
                                    cmd.ExecuteNonQuery();
                                }

                                // 4. Xóa tất cả hóa đơn liên quan đến sản phẩm này
                                string queryDeleteHoaDon = "DELETE FROM HOADON WHERE MA_SANPHAM = @MA_SANPHAM";
                                using (SqlCommand cmd = new SqlCommand(queryDeleteHoaDon, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@MA_SANPHAM", inmaSP);
                                    cmd.ExecuteNonQuery();
                                }

                                // 5. Xóa tất cả thương hiệu liên quan đến sản phẩm này (nếu có)
                                string queryDeleteThuongHieu = "DELETE FROM THUONGHIEU WHERE MA_SANPHAM = @MA_SANPHAM";
                                using (SqlCommand cmd = new SqlCommand(queryDeleteThuongHieu, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@MA_SANPHAM", inmaSP);
                                    cmd.ExecuteNonQuery();
                                }

                                // 6. Cuối cùng, xóa sản phẩm trong bảng SANPHAM
                                string queryDeleteSanPham = "DELETE FROM SANPHAM WHERE MA_SANPHAM = @MA_SANPHAM";
                                using (SqlCommand cmd = new SqlCommand(queryDeleteSanPham, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@MA_SANPHAM", inmaSP);
                                    cmd.ExecuteNonQuery();
                                }

                                transaction.Commit(); // Lưu thay đổi
                                MessageBox.Show("Xóa sản phẩm, hóa đơn, phiếu nhập, phiếu chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoadSanPham(); // Cập nhật lại danh sách
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback(); // Hoàn tác nếu lỗi xảy ra
                                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể lấy mã sản phẩm! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
