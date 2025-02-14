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
    public partial class UC_ThemSanPham : UserControl
    {
        private Panel pnlContent;
        private string connectionString = "Data Source=DESKTOP-N5BJBSG;Initial Catalog=QL_BanHang;Integrated Security=True";
        public UC_ThemSanPham(Panel contentPanel)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.pnlContent = contentPanel;
            LoadLoaiSanPham();
        }
        private void LoadLoaiSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MA_LOAI, TEN_LOAI FROM LOAI_SANPHAM";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cbo_loaiSP.DataSource = dt;
                    cbo_loaiSP.DisplayMember = "TEN_LOAI";
                    cbo_loaiSP.ValueMember = "MA_LOAI";
                }
            }
        }
        private void btn_chonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_anhSP.Image = Image.FromFile(ofd.FileName);
                pic_anhSP.Tag = ofd.FileName;
            }
        }
        private void btn_luuSP_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO SANPHAM (TEN_SANPHAM, MA_LOAI, LOAI_SANPHAM, MOTA_SANPHAM, ANH_SANPHAM, NGAYCAPPHAT_SANPHAM, SOLUONGTON_SANPHAM, CONGDUNG_SANPHAM)
                    VALUES (@TEN_SANPHAM, @MA_LOAI, @LOAI_SANPHAM, @MOTA_SANPHAM, @ANH_SANPHAM, @NGAYCAPPHAT_SANPHAM, @SOLUONGTON_SANPHAM, @CONGDUNG_SANPHAM)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TEN_SANPHAM", txt_tenSanPham.Text);
                        cmd.Parameters.AddWithValue("@LOAI_SANPHAM", cbo_loaiSP.Text);
                        cmd.Parameters.AddWithValue("@MA_LOAI", cbo_loaiSP.SelectedValue);
                        cmd.Parameters.AddWithValue("@MOTA_SANPHAM", rtb_moTa.Text);
                        cmd.Parameters.AddWithValue("@NGAYCAPPHAT_SANPHAM", dtp_ngaynhapHang.Value);
                        cmd.Parameters.AddWithValue("@SOLUONGTON_SANPHAM", num_soLuong.Value);
                        cmd.Parameters.AddWithValue("@CONGDUNG_SANPHAM", txt_congDung.Text);

                        if (pic_anhSP.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pic_anhSP.Image.Save(ms, pic_anhSP.Image.RawFormat);
                                cmd.Parameters.AddWithValue("@ANH_SANPHAM", ms.ToArray());
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ANH_SANPHAM", DBNull.Value);
                        }

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UC_SanPham ucSanPham = new UC_SanPham(pnlContent);
            pnlContent.Controls.Add(ucSanPham);
            ucSanPham.Dock = DockStyle.Fill;
        }

        
    }
}
