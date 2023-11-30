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
    public partial class FormThuThemLaptop : Form
    {
        public FormThuThemLaptop()
        {
            InitializeComponent();
        }

        public void fillThuongHieu()
        {
            using (var db = new TRaCe_Shop())
            {
                foreach (var item in db.ThuongHieus)
                {
                    cmbThuongHieu.Items.Add(item.TenThuongHieu);
                }
            }
        }

        public void fillChatLieu()
        {
            using (var db = new TRaCe_Shop())
            {
                foreach (var item in db.ChatLieus)
                {
                    cmbChatLieu.Items.Add(item.TenChatLieu);
                }
            }
        }

        public void fillRam()
        {
            using (var db = new TRaCe_Shop())
            {
                foreach (var item in db.Rams)
                {
                    cmbRam.Items.Add(item.LoaiRam);
                }
            }
        }

        public void fillCPU()
        {
            using (var db = new TRaCe_Shop())
            {
                foreach (var item in db.CPUs)
                {
                    cmbCPU.Items.Add(item.TenCPU);
                }
            }
        }

        public void fillLoaiLT()
        {
            using (var db = new TRaCe_Shop())
            {
                foreach (var item in db.LoaiLapTops)
                {
                    cmbLoaiLT.Items.Add(item.TenLoai);
                }
            }
        }

        private void FormThuThemLaptop_Load(object sender, EventArgs e)
        {
            fillThuongHieu();
            fillChatLieu();
            fillRam();
            fillCPU();
            fillLoaiLT();
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

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public string TaoID_Laptop()
        {
            using (var db = new TRaCe_Shop())
            {
                for (int i = 1; i <= 1000000; i++)
                {
                    string id_LT = "LT" + i.ToString();

                    var result = db.LapTops.Where(p => p.ID_Laptop == id_LT).FirstOrDefault();

                    if (result == null)
                    {
                        return id_LT;
                    }
                }

                // Nếu không tìm thấy ID không trùng sau khi lặp qua 1 triệu lần
                throw new Exception("Không thể tạo mã ID không trùng trong phạm vi 1 triệu.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using(var db = new TRaCe_Shop())
            {
                LapTop lapTop = new LapTop();
                lapTop.ID_Laptop = TaoID_Laptop();
                lapTop.TenLapTop = txtTenLaptop.Text;
                lapTop.GiaBan = double.Parse(txtGiaBan.Text);
                lapTop.NgaySanXuat = DateTime.Parse(txtNamSX.Text);
                lapTop.HinhAnh = ConvertImageToByteArray(ptbHinhAnh.Image);
                var thuongHieu = db.ThuongHieus.Where(p => p.TenThuongHieu == cmbThuongHieu.Text).FirstOrDefault();
                lapTop.ID_ThuongHieu = thuongHieu.ID_ThuongHieu;
                var chatLieu = db.ChatLieus.Where(p => p.TenChatLieu == cmbChatLieu.Text).FirstOrDefault();
                lapTop.ID_ChatLieu = chatLieu.ID_ChatLieu;
                var ram = db.Rams.Where(p => p.LoaiRam == cmbRam.Text).FirstOrDefault();
                lapTop.ID_Ram = ram.ID_Ram;
                var cpu = db.CPUs.Where(p => p.TenCPU == cmbCPU.Text).FirstOrDefault(); 
                lapTop.ID_CPU = cpu.ID_CPU;
                var loaiLT = db.LoaiLapTops.Where(p => p.TenLoai == cmbLoaiLT.Text).FirstOrDefault();
                lapTop.ID_LoaiLapTop = loaiLT.ID_LoaiLaptop;
                lapTop.ID_BASE = 4;
                db.LapTops.Add(lapTop);
                db.SaveChanges();
                MessageBox.Show("Thêm laptop thành công!", "Thông Báo", MessageBoxButtons.OK);
            }

            
        }
    }

    
}
