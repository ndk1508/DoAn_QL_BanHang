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
    public partial class UC_NhaCC : UserControl
    {
        private string connectionString = "Data Source=DESKTOP-N5BJBSG;Initial Catalog=QL_BanHang;Integrated Security=True;Encrypt=False;";
        public UC_NhaCC()
        {
            InitializeComponent();
        }
        // Hàm kết nối SQL Server
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Load dữ liệu thương hiệu vào ComboBox
        private void LoadThuongHieu()
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT MA_TH, TEN_TH FROM THUONGHIEU";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbThuongHieu.DataSource = dt;
                cbThuongHieu.DisplayMember = "TEN_TH"; // Hiển thị tên thương hiệu
                cbThuongHieu.ValueMember = "MA_TH";    // Lưu giá trị mã thương hiệu
            }
        }

        // Load dữ liệu nhà phân phối lên DataGridView
        private void LoadNhaPhanPhoi()
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                    SELECT 
                        NSX.MA_NSX, 
                        NSX.MA_TH, 
                        TH.TEN_TH, 
                        NSX.TEN_NSX, 
                        NSX.SDT_NSX, 
                        NSX.DIACHI_NSX
                    FROM NHA_SAN_XUAT NSX
                    JOIN THUONGHIEU TH ON NSX.MA_TH = TH.MA_TH";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvNhaPhanPhoi.DataSource = dt;
            }
        }

        // Reset lại các ô nhập
        private void ResetFields()
        {
            txtNhaPhanPhoi.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            cbThuongHieu.SelectedIndex = 0;
        }
        private void LoadNhaSanXuat()
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT MA_NSX, TEN_NSX FROM NHA_SAN_XUAT"; // Đảm bảo tên cột đúng
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvNhaPhanPhoi.DataSource = dt; // Đảm bảo dgvNhaSanXuat hiển thị đúng danh sách
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào được chọn không
            if (dgvNhaPhanPhoi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà sản xuất cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã NSX từ DataGridView
            int maNSX;
            try
            {
                maNSX = Convert.ToInt32(dgvNhaPhanPhoi.SelectedRows[0].Cells["MA_NSX"].Value);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy cột MA_NSX trong DataGridView!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà sản xuất này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                try
                {
                    // Xóa nhà sản xuất khỏi bảng NHA_SAN_XUAT
                    string deleteQuery = "DELETE FROM NHA_SAN_XUAT WHERE MA_NSX = @MA_NSX";
                    SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@MA_NSX", maNSX);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNhaSanXuat(); // Cập nhật danh sách
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhà sản xuất cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void cbThuongHieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_NhaCC_Load(object sender, EventArgs e)
        {
            LoadThuongHieu();  // Load danh sách thương hiệu vào ComboBox
            LoadNhaPhanPhoi();  // Load danh sách nhà phân phối vào DataGridView
            LoadNhaSanXuat();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string tenNPP = txtNhaPhanPhoi.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            int maTH;

            // Kiểm tra thông tin nhập vào
            if (string.IsNullOrEmpty(tenNPP) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy giá trị MA_TH từ ComboBox
            if (!int.TryParse(cbThuongHieu.SelectedValue.ToString(), out maTH))
            {
                MessageBox.Show("Thương hiệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                // Kiểm tra xem MA_TH có tồn tại trong bảng THUONGHIEU không
                string checkQuery = "SELECT COUNT(*) FROM THUONGHIEU WHERE MA_TH = @MA_TH";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MA_TH", maTH);

                int count = (int)checkCmd.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("Mã thương hiệu không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }

                // Thêm nhà phân phối mới
                string query = @"
                INSERT INTO NHA_SAN_XUAT (MA_TH, TEN_NSX, DIACHI_NSX, SDT_NSX)
                VALUES (@MA_TH, @TEN_NSX, @DIACHI_NSX, @SDT_NSX)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MA_TH", maTH);
                cmd.Parameters.AddWithValue("@TEN_NSX", tenNPP);
                cmd.Parameters.AddWithValue("@DIACHI_NSX", diaChi);
                cmd.Parameters.AddWithValue("@SDT_NSX", soDienThoai);

                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (result > 0)
                {
                    MessageBox.Show("Thêm nhà phân phối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhaPhanPhoi(); // Cập nhật lại DataGridView
                    ResetFields(); // Xóa các ô nhập sau khi lưu thành công
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
