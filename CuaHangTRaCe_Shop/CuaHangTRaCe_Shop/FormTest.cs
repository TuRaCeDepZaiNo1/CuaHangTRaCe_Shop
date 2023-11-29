using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using CuaHangTRaCe_Shop.DataBase;
using CuaHangTRaCe_Shop.Models;
using System.IO;

namespace CuaHangTRaCe_Shop.Views
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using(var db = new TRaCe_Shop())
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

        // Hàm chuyển đổi hình ảnh thành byte[]
        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            this.Hide();
            XemThuongHieu frm = new XemThuongHieu();
            frm.ShowDialog();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptbHinhAnh_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
