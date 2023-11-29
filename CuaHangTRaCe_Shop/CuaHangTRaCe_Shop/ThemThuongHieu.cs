using CuaHangTRaCe_Shop.DataBase;
using CuaHangTRaCe_Shop.Models;
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

namespace CuaHangTRaCe_Shop
{
    public partial class ThemThuongHieu : Form
    {
        public ThemThuongHieu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                ThuongHieu thuongHieu = new ThuongHieu();
                thuongHieu.ID_ThuongHieu = txtID.Text;
                thuongHieu.TenThuongHieu = txtTen.Text;
                thuongHieu.HinhAnh = ConvertImageToByteArray(ptbHinhAnh.Image);
                db.ThuongHieus.Add(thuongHieu);
                db.SaveChanges();
                MessageBox.Show("Thêm thương hiệu thành công!", "Thông Báo", MessageBoxButtons.OK);
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

        private void btnLoad_Click(object sender, EventArgs e)
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
    }
}
