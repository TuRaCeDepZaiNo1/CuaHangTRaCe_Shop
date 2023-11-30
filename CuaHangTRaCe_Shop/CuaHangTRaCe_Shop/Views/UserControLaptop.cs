using CuaHangTRaCe_Shop.DataBase;
using Microsoft.VisualBasic;
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
    public partial class UserControLaptop : UserControl
    {
        public UserControLaptop()
        {
            InitializeComponent();
        }
        
        public void FillLoaiLaptop()
        {
            cmbLoaiLaptop.Items.Clear();
            using (var db = new TRaCe_Shop()) 
            {
                foreach (var item in db.LoaiLapTops)
                {
                    cmbLoaiLaptop.Items.Add(item.TenLoai);
                }
            }
        }

        public void FillRam()
        {
            cmbRam.Items.Clear();
            using (var db = new TRaCe_Shop())
            {
                foreach (var item in db.Rams)
                {
                    cmbRam.Items.Add(item.LoaiRam);
                }
            }
        }

        public void FillCPU()
        {   
            cmbCpu.Items.Clear();
            using (var db = new TRaCe_Shop())
            {
                foreach (var item in db.CPUs)
                {
                    cmbCpu.Items.Add(item.TenCPU);
                }
            }
        }

        public void FillLaptop()
        {
            using(var db = new TRaCe_Shop())
            {
                foreach(var lapTop in db.LapTops)
                {
                    UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(lapTop.HinhAnh), lapTop.TenLapTop, ChuyenRam(lapTop.ID_Ram), ChuyenCPU(lapTop.ID_CPU));
                    flpDanhMucLapTop.Controls.Add(user);
                }
            }
        }

        public string ChuyenRam(string idRam)
        {
            string tenRam = string.Empty;
            using(var db = new TRaCe_Shop())
            {
                var result = db.Rams.Where(p => p.ID_Ram == idRam).FirstOrDefault();
                tenRam = result.LoaiRam.ToString();
            }
            return tenRam;
        }

        public string ChuyenCPU(string idCPU)
        {
            string tenCPU = string.Empty;
            using (var db = new TRaCe_Shop())
            {
                var result = db.CPUs.Where(p => p.ID_CPU == idCPU).FirstOrDefault();
                tenCPU = result.TenCPU.ToString();
            }
            return tenCPU;
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

        private void UserControLaptop_Load(object sender, EventArgs e)
        {
            cmbLoaiLaptop.Text = "Loại Laptop";
            cmbCpu.Text = "CPU";
            cmbRam.Text = "Ram";
            cmbMucGia.Text = "Mức giá";
            FillCPU();
            FillRam();
            FillLoaiLaptop();
            FillLaptop();
        }

        public void LoadForm()
        {
            cmbLoaiLaptop.Text = "Loại Laptop";
            cmbCpu.Text = "CPU";
            cmbRam.Text = "Ram";
            cmbMucGia.Text = "Mức giá";
            FillCPU();
            FillRam();
            FillLoaiLaptop();
        }
    }
}
