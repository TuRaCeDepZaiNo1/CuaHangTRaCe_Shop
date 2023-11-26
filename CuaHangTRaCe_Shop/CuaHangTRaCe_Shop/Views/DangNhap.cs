using CuaHangTRaCe_Shop.Controllers;
using CuaHangTRaCe_Shop.DataBase;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public DangNhap(string User, string Password):this()
        {
            txtUser.Text = User;
            txtPassWord.Text = Password;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            using(var db = new TRaCe_Shop())
            {
                foreach(var taiKhoan in db.TaiKhoans)
                {
                    ListTaiKhoan.listTaiKhoan.Add(taiKhoan);
                }
            }
        }

        private void btnHienAn_Click(object sender, EventArgs e)
        {
            if (txtPassWord.PasswordChar == '*')
            {
                txtPassWord.PasswordChar = '\0'; // Hiển thị mật khẩu
                btnHienAn.Image = Properties.Resources.view; // Hình ảnh cho trạng thái ẩn mật khẩu
            }
            else
            {
                txtPassWord.PasswordChar = '*'; // Ẩn mật khẩu
                btnHienAn.Image = Properties.Resources.hide; // Hình ảnh cho trạng thái hiển thị mật khẩu
            }
        }

        private void lblDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKi dangKi = new DangKi();
            dangKi.ShowDialog();
        }

        private void lblDangKy_MouseEnter(object sender, EventArgs e)
        {
            lblDangKy.Font = new Font(lblDangKy.Font, FontStyle.Regular);
            lblDangKy.ForeColor = Color.White;
        }

        private void lblDangKy_MouseLeave(object sender, EventArgs e)
        {
            lblDangKy.Font = new Font(lblDangKy.Font, FontStyle.Regular);
            lblDangKy.ForeColor = Color.Black;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using(var db = new TRaCe_Shop())
            {
                if(txtUser.Text == string.Empty || txtPassWord.Text == string.Empty)
                {
                    MessageBox.Show("Chưa nhập đủ thông tin tài khoản!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    var User = ListTaiKhoan.listTaiKhoan.Where(p => p.TenTaikhoan == txtUser.Text).FirstOrDefault();
                    if (User != null)
                    {
                        if (User.MatKhau == txtPassWord.Text)
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK);
                            this.Hide();
                            Loading frm1 = new Loading();
                            frm1.ShowDialog();
                            var hoTen = db.NguoiDungs.Where(p => p.ID_TaiKhoan.Equals(User.ID_TaiKhoan)).FirstOrDefault();
                            MainForm frm = new MainForm(hoTen.HoTen,hoTen.ChucNang);
                            frm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu!", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            
        }
    }
}
