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

        public UC_SanPham(Panel contentPanel)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.pnlContent = contentPanel;// Gán panel được truyền vào
            LoadSanPham();
            
        }
        private void LoadSanPham(string tuKhoa = "")
        {
            string query = @"SELECT MA_SANPHAM, ANH_SANPHAM, TEN_SANPHAM, LOAI_SANPHAM.TEN_LOAI AS LOAI_SANPHAM, MOTA_SANPHAM, NGAYCAPPHAT_SANPHAM, SOLUONGTON_SANPHAM, CONGDUNG_SANPHAM 
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

        private void btn_xoaSP_Click(object sender, EventArgs e)// xóa sản phẩm
        {
            if (dgv_danhsachSP.CurrentRow != null) // Kiểm tra dòng hiện tại
            {
                int inmaSP;
                if (int.TryParse(dgv_danhsachSP.CurrentRow.Cells["MA_SANPHAM"].Value.ToString(), out inmaSP))
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?",
                                                          "Xác nhận xóa",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "DELETE FROM SANPHAM WHERE MA_SANPHAM = @MA_SANPHAM"; 

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@MA_SANPHAM", inmaSP);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSanPham(); // Cập nhật lại danh sách
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
    }
}
