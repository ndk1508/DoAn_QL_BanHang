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
    public partial class frmMainNV : Form
    {
        public frmMainNV()
        {
            InitializeComponent();
            LoadForm(new UC_Home()); // Mặc định hiển thị UC_Home
        }
        private void LoadForm(UserControl userControl)
        {
            panel2.Controls.Clear(); // Xóa nội dung cũ
            userControl.Dock = DockStyle.Fill; // Lấp đầy panelContent
            panel2.Controls.Add(userControl); // Thêm UC mới vào panelContent
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            LoadForm(new UC_Home());
        }

        private void btn_khachHang_Click(object sender, EventArgs e)
        {
            LoadForm(new UC_KhachHang());
        }
    }
}
