using CuaHangTRaCe_Shop.DataBase;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        UserControlTrangChu usertrangchu = new UserControlTrangChu();
        UserControlDanhSachThuongHieu userthuonghieu = new UserControlDanhSachThuongHieu();
        UserControLaptop userlaptop = new UserControLaptop();
        
        

        public MainForm(string HoTen, string ChucVu) : this()
        {
            txtTenNguoiDung.Text = HoTen;
            txtChucVu.Text = ChucVu;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            pnlLienHe.Visible = false;
            pnlQuanLi.Visible = false;
            if(txtChucVu.Text == "Quản Lí")
            {
                btnQuanLi.Visible = true;
                btnQuanLiTaiKhoan.Visible = true;
            }
            else
            {
                btnQuanLi.Visible = false;
                btnQuanLiTaiKhoan.Visible  = false;
            }
            pnlHienThiLuaChon.Controls.Add(usertrangchu);
            usertrangchu.Visible = true;
            pnlHienThiLuaChon.Controls.Add(userthuonghieu);
            userthuonghieu.Visible = false;
            pnlHienThiLuaChon.Controls.Add(userlaptop);
            userlaptop.Visible = false;
            lblHienThi.Text = "Trang Chủ";
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
            pnlQuanLi.Visible = false;
            lblHienThi.Text = "Danh Mục Sản Phẩm";
            txtSearch.Text = string.Empty;


        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            lblHienThi.Text = "Danh Mục Sản Phẩm / Laptop";
            txtSearch.Text = string.Empty;
            userlaptop.Visible = true;
            usertrangchu.Visible = false;
            userthuonghieu.Visible = false;
            userlaptop.LoadForm();
        }

        private void btnPhuKien_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            lblHienThi.Text = "Danh Mục Sản Phẩm / Phụ Kiện";
            txtSearch.Text = string.Empty;

        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            lblHienThi.Text = "Danh Mục Sản Phẩm / Ram";
            txtSearch.Text = string.Empty;

        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            lblHienThi.Text = "Danh Mục Sản Phẩm / CPU";
            txtSearch.Text = string.Empty;

        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            pnlLienHe.Visible = !pnlLienHe.Visible;
            pnlDanhMucSanPham.Visible = false;
            pnlQuanLi.Visible = false;
            lblHienThi.Text = "Liên Hệ";
            txtSearch.Text = string.Empty;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Trang Chủ";
            usertrangchu.Visible = true;
            userthuonghieu.Visible = false;
            txtSearch.Text = string.Empty;
        }

        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Thương Hiệu";
            userthuonghieu.fillAll();
            userthuonghieu.Visible = true;
            usertrangchu.Visible = false;
            txtSearch.Text = string.Empty;
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Giỏ Hàng";
            txtSearch.Text = string.Empty;

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Thanh Toán";
            txtSearch.Text = string.Empty;

        }

        private void btnQuanLiTaiKhoan_Click(object sender, EventArgs e)
        {
            pnlDanhMucSanPham.Visible = false;
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Quản Lí Tài Khoản";
            txtSearch.Text = string.Empty;

        }

        private void btnMesseger_Click(object sender, EventArgs e)
        {
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Liên Hệ / Messager";
            txtSearch.Text = string.Empty;

        }

        private void btnTongDai_Click(object sender, EventArgs e)
        {
            pnlLienHe.Visible = false;
            lblHienThi.Text = "Liên Hệ / Tổng Đài";
            txtSearch.Text = string.Empty;

        }

        private void btnQuanLi_Click(object sender, EventArgs e)
        {
            pnlQuanLi.Visible = !pnlQuanLi.Visible;
            pnlLienHe.Visible = false;
            pnlDanhMucSanPham.Visible = false;
            lblHienThi.Text = "Quản Lí";
            txtSearch.Text = string.Empty;
        }

        private void btnQLThuongHieu_Click(object sender, EventArgs e)
        {
            pnlQuanLi.Visible = false;
            lblHienThi.Text = "Quản Lí / Thương Hiệu";
            txtSearch.Text = string.Empty;

        }

        private void btnQLDonBan_Click(object sender, EventArgs e)
        {
            pnlQuanLi.Visible = false;
            lblHienThi.Text = "Quản Lí / Đơn Bán";
            txtSearch.Text = string.Empty;

        }

        private void btnQLDonNhap_Click(object sender, EventArgs e)
        {
            pnlQuanLi.Visible = false;
            lblHienThi.Text = "Quản Lí / Đơn Nhập";
            txtSearch.Text = string.Empty;

        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            pnlQuanLi.Visible = false;
            lblHienThi.Text = "Quản Lí / Sản Phẩm";
            txtSearch.Text = string.Empty;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using(var db = new TRaCe_Shop())
            {
                if (lblHienThi.Text == "Thương Hiệu")
                {
                    var search = db.ThuongHieus.Where(p => p.TenThuongHieu == txtSearch.Text).FirstOrDefault();
                    if(search != null)
                    {
                        userthuonghieu.fillTimKiem(search.TenThuongHieu);
                    }   
                }
            }
            
        }

        public Image ConvertBinaryDataToImage(byte[] binaryData)
        {
            try
            {
                if (binaryData == null || binaryData.Length == 0)
                {
                    // Trả về null nếu dữ liệu là null hoặc rỗng
                    return null;
                }

                using (MemoryStream memoryStream = new MemoryStream(binaryData))
                {
                    // Đọc dữ liệu từ MemoryStream và chuyển đổi thành đối tượng Image
                    Image image = Image.FromStream(memoryStream);
                    return image;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine("Lỗi chuyển đổi hình ảnh: " + ex.Message);
                return null;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                if(lblHienThi.Text == "Thương Hiệu")
                {
                    userthuonghieu.fillAll();
                }
                
            }
        }
    }
}
