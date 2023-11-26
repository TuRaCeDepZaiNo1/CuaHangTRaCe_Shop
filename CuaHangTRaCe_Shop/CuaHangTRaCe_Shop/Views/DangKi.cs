using CuaHangTRaCe_Shop.Controllers;
using CuaHangTRaCe_Shop.DataBase;
using CuaHangTRaCe_Shop.Models;
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
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }

        private void DangKi_Load(object sender, EventArgs e)
        {
            tpThongTinCaNhan.Enabled = false;
            txtMaSo.Visible = false;
            lblMaSo.Visible = false;
            using (var db = new TRaCe_Shop())
            {
                // Kiểm tra xem có dữ liệu trong db.PhanQuyens hay không
                if (db.PhanQuyens.Any())
                {
                    // Nếu có, xóa danh sách cũ và thêm mới từ cơ sở dữ liệu
                    ListPhanQuyen.listPhanQuyen.Clear();
                    foreach (var quyen in db.PhanQuyens)
                    {
                        ListPhanQuyen.listPhanQuyen.Add(quyen);
                    }

                    // Thêm mục vào ComboBox
                    foreach (var quyen1 in ListPhanQuyen.listPhanQuyen)
                    {
                        cmbQuyen.Items.Add(quyen1.MoTaQuyen);
                    }
                }
            }
        }

        public string TaoID_TK()
        {
            using (var db = new TRaCe_Shop())
            {
                for (int i = 1; i <= 1000000; i++)
                {
                    string id_TK = "TK" + i.ToString();

                    var result = db.TaiKhoans.Where(p => p.ID_TaiKhoan == id_TK).FirstOrDefault();

                    if (result == null)
                    {
                        return id_TK;
                    }
                }

                // Nếu không tìm thấy ID không trùng sau khi lặp qua 1 triệu lần
                throw new Exception("Không thể tạo mã ID không trùng trong phạm vi 1 triệu.");
            }
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            using(var db = new TRaCe_Shop())
            {
                if(txtTentaiKhoan.Text == "" || txtMatKhau.Text == "" || txtXacNhanMatKhau.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || cmbQuyen.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin" , "Thông Báo" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var taiKhoan = db.TaiKhoans.Where(p => p.TenTaikhoan == txtTentaiKhoan.Text).FirstOrDefault();
                    if (taiKhoan != null)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại vui lòng nhập tên khác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
                    {
                        MessageBox.Show("Mật khẩu và xác nhận lại mật khẩu không trùng khớp vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtSDT.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại vượt quá kí tự cho phép vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (cmbQuyen.SelectedIndex == 0)
                    {
                        if (txtMaSo.Text != "07062003")
                        {
                            MessageBox.Show("Mã số của quản lí không đúng vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                
                tpThongTinCaNhan.Enabled = true;
                tcDangKi.SelectedTab = tpThongTinCaNhan;
            }
        }



        private void cmbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbQuyen.SelectedIndex == 0)
            {
                txtMaSo.Visible = true;
                lblMaSo.Visible = true;
            }
            else
            {
                txtMaSo.Visible = false;
                lblMaSo.Visible = false;
            }
        }

        public string TaoID_NguoiDung()
        {
            using (var db = new TRaCe_Shop())
            {
                for (int i = 1; i <= 1000000; i++)
                {
                    string id_TK = "ND" + i.ToString();

                    var result = db.NguoiDungs.Where(p => p.ID_NguoiDung == id_TK).FirstOrDefault();

                    if (result == null)
                    {
                        return id_TK;
                    }
                }

                // Nếu không tìm thấy ID không trùng sau khi lặp qua 1 triệu lần
                throw new Exception("Không thể tạo mã ID không trùng trong phạm vi 1 triệu.");
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            using(var db = new TRaCe_Shop())
            {
                if(txtHoTen.Text == "" || dtpNgaySinh.Value == DateTime.MinValue || txtDiaChi.Text == "" || txtMucLuong.Text == "" || dtpNgayVaoLam.Value > DateTime.Now)
                {
                    MessageBox.Show("Thông tin thiếu hoặc bị sai, vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    //Tạo Tài Khoản
                    TaiKhoan tk = new TaiKhoan();
                    tk.ID_TaiKhoan = TaoID_TK();
                    tk.TenTaikhoan = txtTentaiKhoan.Text;
                    tk.MatKhau = txtMatKhau.Text;
                    tk.SDT = txtSDT.Text;
                    tk.Email = txtEmail.Text;
                    tk.ID_Quyen = cmbQuyen.SelectedIndex.ToString();
                    db.TaiKhoans.Add(tk);

                    //Tạo Người Dùng
                    NguoiDung nguoiDung = new NguoiDung();
                    nguoiDung.ID_NguoiDung = TaoID_NguoiDung();
                    nguoiDung.HoTen = txtHoTen.Text;
                    nguoiDung.NgaySinh = dtpNgaySinh.Value;
                    nguoiDung.DiaChi = txtDiaChi.Text;
                    if(tk.ID_Quyen == "0")
                    {
                        nguoiDung.ChucNang = "Quản Lí";
                    }
                    else if (tk.ID_Quyen == "1")
                    {
                        nguoiDung.ChucNang = "Nhân Viên";
                    }
                    if (ptbHinhAnh.Image != null)
                    {
                        nguoiDung.HinhAnh = ConvertImageToByteArray(ptbHinhAnh.Image);
                    }
                    nguoiDung.Luong = double.Parse(txtMucLuong.Text);
                    nguoiDung.NgayVaoLam = dtpNgayVaoLam.Value;
                    nguoiDung.ID_TaiKhoan = tk.ID_TaiKhoan.ToString(); 
                    db.NguoiDungs.Add(nguoiDung);
                    db.SaveChanges();

                    this.Hide();
                    DangNhap dangNhap = new DangNhap(tk.TenTaikhoan,tk.MatKhau);
                    dangNhap.ShowDialog();
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị hình ảnh trong PictureBox
                    ptbHinhAnh.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }
    }
}
