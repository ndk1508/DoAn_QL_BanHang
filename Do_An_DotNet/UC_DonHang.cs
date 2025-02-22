using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Winform_DoAn
{
    public partial class UC_QuanLyDonHang : UserControl
    {
        private readonly string connectionString = "Data Source=DESKTOP-N5BJBSG;Initial Catalog=QL_BanHang;Integrated Security=True";


        public UC_QuanLyDonHang()
        {
            InitializeComponent();

        }

        private void UC_QuanLyDonHang_Load(object sender, EventArgs e)
        {
            //load san pham vao combobox 
            LoadSanPham();
            LoadDataGridView();
        }
        private void LoadSanPham()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MA_SANPHAM, TEN_SANPHAM, SOLUONGTON_SANPHAM, GIA_SANPHAM FROM [SANPHAM]";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            cbSanPham.DataSource = dt;
                            cbSanPham.DisplayMember = "TEN_SANPHAM";  // Hiển thị tên sản phẩm
                            cbSanPham.ValueMember = "MA_SANPHAM";      // Lưu ID sản phẩm
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị thông tin hóa đơn trước khi lưu
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn lưu hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return; // Nếu người dùng không xác nhận, không lưu
                }

                // Lấy selectedProductId từ ComboBox cboSanPham
                int selectedProductId = Convert.ToInt32(cbSanPham.SelectedValue); // Hoặc cboSanPham.SelectedItem nếu dùng Item là đối tượng

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        if (string.IsNullOrWhiteSpace(txtSDT.Text) || txtSDT.Text.Length < 10)
                        {
                            MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // 🔹 Kiểm tra khách hàng tồn tại chưa
                        string checkKhachHangQuery = "SELECT MA_KH FROM KHACH_HANG WHERE SDT_KH = @SDT_KH";
                        SqlCommand cmdCheckKH = new SqlCommand(checkKhachHangQuery, conn, transaction);
                        cmdCheckKH.Parameters.AddWithValue("@SDT_KH", txtSDT.Text);
                        object khachHangID = cmdCheckKH.ExecuteScalar();
                        int maKhachHang;
                        if (khachHangID == null)
                        {
                            // Thêm khách hàng nếu chưa tồn tại
                            string insertKhachHangQuery = @"
                            INSERT INTO KHACH_HANG (HOTEN_KH, SDT_KH) 
                            OUTPUT INSERTED.MA_KH 
                            VALUES (@HOTEN_KH, @SDT_KH)";

                            SqlCommand cmdKhachHang = new SqlCommand(insertKhachHangQuery, conn, transaction);
                            cmdKhachHang.Parameters.AddWithValue("@HOTEN_KH", txtKhachHang.Text);
                            cmdKhachHang.Parameters.AddWithValue("@SDT_KH", txtSDT.Text);

                            maKhachHang = (int)cmdKhachHang.ExecuteScalar();
                        }
                        else
                        {
                            maKhachHang = Convert.ToInt32(khachHangID);
                        }

                        // Lưu hóa đơn vào bảng HOADON
                        string insertHoaDonQuery = @"
                    INSERT INTO HOADON (NGAYLAP_HD, GIAMGIA, MA_KH, SOLUONG, TONGTIEN_HD, MA_SANPHAM) 
                    OUTPUT INSERTED.STT_HD 
                    VALUES (@NGAYLAP_HD, @GIAMGIA, @MA_KH, @SOLUONG, @TONGTIEN_HD, @MA_SANPHAM)";

                        // Lệnh SQL để cập nhật lại số lượng tồn kho trong bảng SANPHAM
                        string updateSanPhamQuery = @"
                    UPDATE SANPHAM 
                    SET SOLUONGTON_SANPHAM = SOLUONGTON_SANPHAM - @SOLUONG 
                    WHERE MA_SANPHAM = @MA_SANPHAM";

                        SqlCommand cmdHoaDon = new SqlCommand(insertHoaDonQuery, conn, transaction);
                        cmdHoaDon.Parameters.AddWithValue("@NGAYLAP_HD", DateTime.Now);
                        cmdHoaDon.Parameters.AddWithValue("@GIAMGIA", Convert.ToDecimal(txtGiamGia.Text));
                        cmdHoaDon.Parameters.AddWithValue("@MA_KH", maKhachHang);
                        cmdHoaDon.Parameters.AddWithValue("@SOLUONG", numericSoLuong.Value);
                        cmdHoaDon.Parameters.AddWithValue("@TONGTIEN_HD", Convert.ToDecimal(txtTongTien.Text));
                        cmdHoaDon.Parameters.AddWithValue("@MA_SANPHAM", selectedProductId);  // selectedProductId là ID của sản phẩm đã chọn

                        // Thực hiện lưu hóa đơn
                        int sttHoaDon = (int)cmdHoaDon.ExecuteScalar();

                        // Cập nhật lại số lượng tồn kho trong bảng SANPHAM
                        SqlCommand cmdUpdateSanPham = new SqlCommand(updateSanPhamQuery, conn, transaction);
                        cmdUpdateSanPham.Parameters.AddWithValue("@SOLUONG", numericSoLuong.Value);
                        cmdUpdateSanPham.Parameters.AddWithValue("@MA_SANPHAM", selectedProductId);

                        // Thực hiện cập nhật số lượng sản phẩm
                        cmdUpdateSanPham.ExecuteNonQuery();

                        // Commit transaction
                        transaction.Commit();

                        MessageBox.Show("Hóa đơn đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadHoaDon(); // Reload danh sách hóa đơn sau khi lưu
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction nếu có lỗi
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }
        // khi chon san pham hien thi gia tien
        private decimal giaGoc = 0; // Lưu giá gốc

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSanPham.SelectedValue != null)
                {
                    int maSanPham;
                    if (int.TryParse(cbSanPham.SelectedValue.ToString(), out maSanPham))
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "SELECT GIA_SANPHAM FROM SANPHAM WHERE MA_SANPHAM = @MA_SANPHAM";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@MA_SANPHAM", maSanPham);
                                object result = cmd.ExecuteScalar();
                                if (result != null)
                                {
                                    giaGoc = Convert.ToDecimal(result); // Lưu giá gốc
                                    txtTongTien.Text = giaGoc.ToString("N0");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy giá sản phẩm: " + ex.Message);
            }
        }
        private decimal MaxGiaTri = 999999999999; // Giới hạn tối đa cho SQL    

        private void numericSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (giaGoc <= 0)
            {
                txtTongTien.Text = "0";
                return;
            }

            decimal soLuong = numericSoLuong.Value;
            if (soLuong <= 0)
            {
                txtTongTien.Text = "0";
                return;
            }

            decimal giamGia = 0;

            // Nếu txtGiamGia chưa có giá trị, tự động tính giảm giá
            if (string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                giamGia = giaGoc * soLuong * 0.1m; // Giảm 10%
                txtGiamGia.Text = giamGia.ToString("N0");
            }
            else if (!decimal.TryParse(txtGiamGia.Text, out giamGia))
            {
                giamGia = 0; // Nếu nhập sai định dạng, đặt về 0
            }

            // Tính tổng tiền
            decimal tongSauGiam = Math.Max(0, giaGoc * soLuong - giamGia);

            // Kiểm tra giới hạn để tránh lỗi SQL
            if (tongSauGiam > MaxGiaTri)
            {
                tongSauGiam = MaxGiaTri;
            }

            txtTongTien.Text = tongSauGiam.ToString("N0");
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (giaGoc <= 0)
            {
                txtTongTien.Text = "0";
                return;
            }

            decimal soLuong = numericSoLuong.Value;
            if (soLuong <= 0)
            {
                txtTongTien.Text = "0";
                return;
            }

            decimal giamGia = 0;

            // Kiểm tra nếu nhập sai định dạng
            if (!decimal.TryParse(txtGiamGia.Text, out giamGia))
            {
                giamGia = 0;
                txtGiamGia.Text = "0"; // Nếu nhập sai thì đặt về 0
            }

            // Giới hạn giảm giá không vượt quá tổng tiền
            decimal tongTienTruocGiam = giaGoc * soLuong;
            if (giamGia > tongTienTruocGiam)
            {
                giamGia = tongTienTruocGiam;
                txtGiamGia.Text = giamGia.ToString("N0"); // Cập nhật lại ô nhập
            }

            // Tính tổng tiền sau giảm giá
            decimal tongSauGiam = Math.Max(0, tongTienTruocGiam - giamGia);

            // Kiểm tra giới hạn để tránh lỗi SQL
            if (tongSauGiam > MaxGiaTri)
            {
                tongSauGiam = MaxGiaTri;
            }

            txtTongTien.Text = tongSauGiam.ToString("N0");
        }
        private void LoadDataGridView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                    SELECT 
                        HD.STT_HD, 
                        SP.TEN_SANPHAM, 
                        HD.NGAYLAP_HD, 
                        KH.HOTEN_KH AS TEN_KH, 
                        HD.SOLUONG, 
                        KH.SDT_KH, 
                        HD.GIAMGIA, 
                        HD.TONGTIEN_HD
                    FROM HOADON HD
                    LEFT JOIN KHACH_HANG KH ON HD.MA_KH = KH.MA_KH
                    LEFT JOIN SANPHAM SP ON HD.MA_SANPHAM = SP.MA_SANPHAM";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvHoaDon.DataSource = dt;
                    dgvHoaDon.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadHoaDon()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                    SELECT H.STT_HD, K.HOTEN_KH, S.TEN_SANPHAM, H.NGAYLAP_HD, H.SOLUONG, H.GIAMGIA, H.TONGTIEN_HD
                    FROM HOADON H
                    JOIN KHACH_HANG K ON H.MA_KH = K.MA_KH
                    JOIN SANPHAM S ON H.MA_SANPHAM = S.MA_SANPHAM";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHoaDon.DataSource = dt;

                    // Tùy chỉnh tên các cột trong DataGridView (nếu cần)
                    dgvHoaDon.Columns["STT_HD"].HeaderText = "Số thứ tự";
                    dgvHoaDon.Columns["HOTEN_KH"].HeaderText = "Tên khách hàng";
                    dgvHoaDon.Columns["TEN_SANPHAM"].HeaderText = "Tên sản phẩm";
                    dgvHoaDon.Columns["NGAYLAP_HD"].HeaderText = "Ngày lập hóa đơn";
                    dgvHoaDon.Columns["SOLUONG"].HeaderText = "Số lượng";
                    dgvHoaDon.Columns["GIAMGIA"].HeaderText = "Giảm giá";
                    dgvHoaDon.Columns["TONGTIEN_HD"].HeaderText = "Tổng tiền";

                    // Tùy chỉnh định dạng cột nếu cần
                    dgvHoaDon.Columns["NGAYLAP_HD"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvHoaDon.Columns["TONGTIEN_HD"].DefaultCellStyle.Format = "N0"; // Định dạng số
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hóa đơn: " + ex.Message);
            }
        }
        private void LoadDanhSachHoaDon()
        {
            try
            {
                if (dgvHoaDon.DataSource != null)
                {
                    dgvHoaDon.DataSource = null; // Hủy liên kết dữ liệu trước khi tải lại
                }
                else
                {
                    dgvHoaDon.Rows.Clear(); // Chỉ xóa nếu không có DataSource
                }

                // Chuỗi kết nối SQL Server
                string connectionString = "Data Source=LAPTOP-4VFJEIV4;Initial Catalog=QL_BanHang;Integrated Security=True;Encrypt=False;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Câu lệnh SQL để lấy dữ liệu hóa đơn
                    string query = "SELECT STT_HD, NGAYLAP_HD, HOTEN_KH, SOLUONG, GIAMGIA FROM HOADON";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();  // Tạo bảng dữ liệu để chứa kết quả truy vấn
                            adapter.Fill(dt); // Đổ dữ liệu vào bảng

                            // Gán lại dữ liệu mới vào DataGridView
                            dgvHoaDon.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Có lỗi xảy ra khi tải danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void XoaHoaDon(int maHoaDon)
        {
            string connectionString = "Data Source=DESKTOP-N5BJBSG;Initial Catalog=QL_BanHang;Integrated Security=True;Encrypt=False;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())  // Tạo transaction
                {
                    try
                    {
                        // Xóa chi tiết hóa đơn trước (nếu có)
                        string deleteChiTietQuery = "DELETE FROM CHITIET_HOADON WHERE STT_HD = @STT_HD";
                        using (SqlCommand deleteChiTietCmd = new SqlCommand(deleteChiTietQuery, conn, transaction))
                        {
                            deleteChiTietCmd.Parameters.AddWithValue("@STT_HD", maHoaDon);
                            deleteChiTietCmd.ExecuteNonQuery();
                        }

                        // Xóa hóa đơn chính
                        string deleteHoaDonQuery = "DELETE FROM HOADON WHERE STT_HD = @STT_HD";
                        using (SqlCommand deleteHoaDonCmd = new SqlCommand(deleteHoaDonQuery, conn, transaction))
                        {
                            deleteHoaDonCmd.Parameters.AddWithValue("@STT_HD", maHoaDon);
                            deleteHoaDonCmd.ExecuteNonQuery();
                        }

                        // Commit transaction nếu không có lỗi
                        transaction.Commit();
                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Chỉ rollback nếu transaction còn khả dụng
                        if (transaction.Connection != null)
                        {
                            transaction.Rollback();
                        }
                        MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Chỉ LoadDanhSachHoaDon() sau khi transaction đã hoàn tất
            LoadDanhSachHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá trị có tồn tại trước khi lấy
            object value = dgvHoaDon.SelectedRows[0].Cells["STT_HD"].Value;
            if (value == null)
            {
                MessageBox.Show("Không thể lấy mã hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chuyển thành kiểu int nếu STT_HD là số
            int maHoaDon;
            if (!int.TryParse(value.ToString(), out maHoaDon))
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tiến hành xóa
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                // Xóa hóa đơn
                XoaHoaDon(maHoaDon);
            }
        }
    }
}
