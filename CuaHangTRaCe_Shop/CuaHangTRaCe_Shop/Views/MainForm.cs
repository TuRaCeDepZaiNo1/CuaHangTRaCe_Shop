using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTRaCe_Shop.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string layHoTen = string.Empty;
        string layChucVu = string.Empty;

        public MainForm(string HoTen, string ChucVu) : this()
        {
            txtTenNguoiDung.Text = HoTen;
            txtChucVu.Text = ChucVu;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            pnlLienHe.Visible = false;
        }

        private void btnDangXuatThoat_Click(object sender, EventArgs e)
        {
            guna2ContextMenuStrip1.Show(btnDangXuatThoat, 1, btnDangXuatThoat.Height);
        }

        private void cmsDangXuat(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap frm = new DangNhap();
            frm.ShowDialog();
        }

        private void cmsThoat(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDanhMucSanPham_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = !pnlDanhMucSanPham.Visible;
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Danh Mục Sản Phẩm";
        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            lblHienThi.Text = "Danh Mục Sản Phẩm / Laptop";
        }

        private void btnPhuKien_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            lblHienThi.Text = "Danh Mục Sản Phẩm / Phụ Kiện";
        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            lblHienThi.Text = "Danh Mục Sản Phẩm / Ram";
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            lblHienThi.Text = "Danh Mục Sản Phẩm / CPU";
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            pnlLienHe.Visible = !pnlLienHe.Visible;
            pnlDanhMucSanPham.Visible = false;
            lblHienThi.Text = "Liên Hệ";
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Trang Chủ";
        }

        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Thương Hiệu";
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Giỏ Hàng";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Thanh Toán";
        }

        private void btnQuanLiTaiKhoan_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Quản Lí Tài Khoản";
        }

        private void btnMesseger_Click(object sender, EventArgs e)
        {
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Liên Hệ / Messager";
        }

        private void btnTongDai_Click(object sender, EventArgs e)
        {
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Liên Hệ / Tổng Đài";
        }
    }
}
