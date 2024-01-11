using CuaHangTRaCe_Shop.DataBase;
using CuaHangTRaCe_Shop.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CuaHangTRaCe_Shop.Views
{
    public partial class UserControLaptop : UserControl
    {
        public UserControLaptop()
        {
            InitializeComponent();
        }

        public UserControLaptop(string loai)
        {
            InitializeComponent();
            using (var db = new TRaCe_Shop())
            {
                List<LapTop> lapTops = new List<LapTop>();
                lapTops = db.LapTops.Where(p => p.ID_LoaiLapTop == loai).ToList();
                flpDanhMucLapTop.Controls.Clear();
                foreach (var item in lapTops)
                {
                    UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                    flpDanhMucLapTop.Controls.Add(user);
                }
            }
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

        public void TimKiem(string loai)
        {
            using (var db = new TRaCe_Shop())
            {
                if (loai == "Gaming")
                {
                    string tim = "1";
                    List<LapTop> lapTops = new List<LapTop>();
                    lapTops = db.LapTops.Where(p => p.ID_LoaiLapTop == tim).ToList();
                    flpDanhMucLapTop.Controls.Clear();
                    foreach (var item in lapTops)
                    {
                        UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                        flpDanhMucLapTop.Controls.Add(user);
                    }
                }
                else if (loai == "Macbook")
                {
                    string tim = "2";
                    List<LapTop> lapTops = new List<LapTop>();
                    lapTops = db.LapTops.Where(p => p.ID_LoaiLapTop == tim).ToList();
                    flpDanhMucLapTop.Controls.Clear();
                    foreach (var item in lapTops)
                    {
                        UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                        flpDanhMucLapTop.Controls.Add(user);
                    }
                }
                else if (loai == "Mỏng nhẹ")
                {
                    string tim = "3";
                    List<LapTop> lapTops = new List<LapTop>();
                    lapTops = db.LapTops.Where(p => p.ID_LoaiLapTop == tim).ToList();
                    flpDanhMucLapTop.Controls.Clear();
                    foreach (var item in lapTops)
                    {
                        UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                        flpDanhMucLapTop.Controls.Add(user);
                    }
                }
                else if (loai == "Đồ họa, thiết kế")
                {
                    string tim = "4";
                    List<LapTop> lapTops = new List<LapTop>();
                    lapTops = db.LapTops.Where(p => p.ID_LoaiLapTop == tim).ToList();
                    flpDanhMucLapTop.Controls.Clear();
                    foreach (var item in lapTops)
                    {
                        UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                        flpDanhMucLapTop.Controls.Add(user);
                    }
                }
                else if (loai == "Sang trọng")
                {
                    string tim = "5";
                    List<LapTop> lapTops = new List<LapTop>();
                    lapTops = db.LapTops.Where(p => p.ID_LoaiLapTop == tim).ToList();
                    flpDanhMucLapTop.Controls.Clear();
                    foreach (var item in lapTops)
                    {
                        UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                        flpDanhMucLapTop.Controls.Add(user);
                    }
                }

            }
        }

        /*
         * flpDanhMucLapTop.Controls.Clear();
         foreach (var item in laptops1)
                        {
                            UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                            flpDanhMucLapTop.Controls.Add(user);
                        }
         */

        public List<LapTop> LocChucNang(List<LapTop> laptops)
        {
            List<LapTop> laptops1 = new List<LapTop>();
            if (cmbLoaiLaptop.Text != null && cmbLoaiLaptop.Text != "Loại Laptop")
            {
                if (cmbLoaiLaptop.Text == "Gaming")
                {
                    string tim = "1";
                    laptops1 = laptops.Where(p => p.ID_LoaiLapTop == tim).ToList();
                }
                else if (cmbLoaiLaptop.Text == "Macbook")
                {
                    string tim = "2";
                    laptops1 = laptops.Where(p => p.ID_LoaiLapTop == tim).ToList();
                }
                else if (cmbLoaiLaptop.Text == "Mỏng nhẹ")
                {
                    string tim = "3";
                    laptops1 = laptops.Where(p => p.ID_LoaiLapTop == tim).ToList();
                }
                else if (cmbLoaiLaptop.Text == "Đồ họa, thiết kế")
                {
                    string tim = "4";
                    laptops1 = laptops.Where(p => p.ID_LoaiLapTop == tim).ToList();
                }
                else if (cmbLoaiLaptop.Text == "Sang trọng")
                {
                    string tim = "5";
                    laptops1 = laptops.Where(p => p.ID_LoaiLapTop == tim).ToList();
                }
            }
            else 
            {
                return laptops;
            }
            return laptops1;
        }

        public List<LapTop> LocMucGia(List<LapTop> lapTops)
        {
            List<LapTop> lapTop1 = new List<LapTop>();
            if (cmbMucGia.Text != null && cmbMucGia.Text != "Mức giá")
            {
                if (cmbMucGia.Text == "Dưới 10 triệu")
                {
                    lapTop1 = lapTops.Where(p => p.GiaBan < 10000000).ToList();
                }
                else if (cmbMucGia.Text == "10 - 15 triệu")
                {
                    lapTop1 = lapTops.Where(p => p.GiaBan >= 10000000 && p.GiaBan <= 15000000).ToList();
                }
                else if (cmbMucGia.Text == "15 - 20 triệu")
                {
                    lapTop1 = lapTops.Where(p => p.GiaBan >= 15000000 && p.GiaBan <= 20000000).ToList();
                }
                else if (cmbMucGia.Text == "20 - 25 triệu")
                {
                    lapTop1 = lapTops.Where(p => p.GiaBan >= 20000000 && p.GiaBan <= 25000000).ToList();
                }
                else if (cmbMucGia.Text == "25 - 30 triệu")
                {
                    lapTop1 = lapTops.Where(p => p.GiaBan >= 25000000 && p.GiaBan <= 30000000).ToList();
                }
                else if (cmbMucGia.Text == "Trên 30 triệu")
                {
                    lapTop1 = lapTops.Where(p => p.GiaBan > 30000000).ToList();
                }
            }
            else 
            {
                return lapTops;
            }
            return lapTop1;
        }

        public List<LapTop> LocRam(List<LapTop> lapTops)
        {
            List<LapTop> list = new List<LapTop>();
            if (cmbRam.Text != null && cmbRam.Text != "Ram")
            {
                if (cmbRam.Text == "DDR3(8)")
                {
                    string ram = "R1";
                    list = lapTops.Where(p => p.ID_Ram == ram).ToList();
                }
                else if (cmbRam.Text == "DDR3(16)")
                {
                    string ram = "R2";
                    list = lapTops.Where(p => p.ID_Ram == ram).ToList();
                }
                else if (cmbRam.Text == "DDR4(8)")
                {
                    string ram = "R3";
                    list = lapTops.Where(p => p.ID_Ram == ram).ToList();
                }
                else if (cmbRam.Text == "DDR4(16)")
                {
                    string ram = "R4";
                    list = lapTops.Where(p => p.ID_Ram == ram).ToList();
                }
            }
            else
            {
                return lapTops;
            }
            return list;
        }

        public List<LapTop> LocCpu(List<LapTop> lapTops)
        {
            List<LapTop> list = new List<LapTop>();
            if (cmbCpu.Text != null && cmbCpu.Text != "CPU")
            {
                if (cmbCpu.Text == "Intel Core i3")
                {
                    string cpu = "CPU1";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
                else if (cmbCpu.Text == "Intel Core i5")
                {
                    string cpu = "CPU2";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
                else if (cmbCpu.Text == "Intel Core i7")
                {
                    string cpu = "CPU3";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
                else if (cmbCpu.Text == "Intel Core i9")
                {
                    string cpu = "CPU4";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
                else if (cmbCpu.Text == "AMD Ryzen 3")
                {
                    string cpu = "CPU5";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
                else if (cmbCpu.Text == "AMD Ryzen 5")
                {
                    string cpu = "CPU6";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
                else if (cmbCpu.Text == "AMD Ryzen 7")
                {
                    string cpu = "CPU7";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
                else if (cmbCpu.Text == "AMD Ryzen 9")
                {
                    string cpu = "CPU8";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
                else if (cmbCpu.Text == "Apple M1")
                {
                    string cpu = "CPU10";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
                else if (cmbCpu.Text == "Apple M2")
                {
                    string cpu = "CPU11";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
                else if (cmbCpu.Text == "Apple M2 Pro")
                {
                    string cpu = "CPU12";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
                else if (cmbCpu.Text == "Apple M3")
                {
                    string cpu = "CPU13";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
                else if (cmbCpu.Text == "Apple M3 MAX")
                {
                    string cpu = "CPU14";
                    list = lapTops.Where(p => p.ID_CPU == cpu).ToList();
                }
            }
            else
            {
                return lapTops;
            }
            return list;
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            LoadForm();
            flpDanhMucLapTop.Controls.Clear();
            FillLaptop();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            List<LapTop> list = new List<LapTop>();
            List<LapTop> list0 = new List<LapTop>();
            List<LapTop> list1 = new List<LapTop>();
            List<LapTop> list2 = new List<LapTop>();
            List<LapTop> list3 = new List<LapTop>();
            using (var db = new TRaCe_Shop())
            {
                if (cmbLoaiLaptop.Text != "Loại Laptop" || cmbMucGia.Text != "Mức giá" || cmbRam.Text != "Ram" || cmbCpu.Text != "CPU")
                {
                    list = db.LapTops.ToList();
                    list0 = LocChucNang(list);
                    list1 = LocMucGia(list0);
                    list2 = LocRam(list1);
                    list3 = LocCpu(list2);
                    flpDanhMucLapTop.Controls.Clear();
                    foreach (var item in list3)
                    {
                        UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                        flpDanhMucLapTop.Controls.Add(user);
                    }
                }
            }
        }

        #region Button_Hang
        private void btnAsus_Click(object sender, EventArgs e)
        {
            using(var db = new TRaCe_Shop())
            {
                string thuongHieu = "TH2";
                List<LapTop> lapTops = new List<LapTop>();
                lapTops = db.LapTops.Where(p => p.ID_ThuongHieu == thuongHieu).ToList();
                flpDanhMucLapTop.Controls.Clear();
                foreach (var item in lapTops)
                {
                    UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                    flpDanhMucLapTop.Controls.Add(user);
                }
            }
        }

        private void btnAcer_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                string thuongHieu = "TH3";
                List<LapTop> lapTops = new List<LapTop>();
                lapTops = db.LapTops.Where(p => p.ID_ThuongHieu == thuongHieu).ToList();
                flpDanhMucLapTop.Controls.Clear();
                foreach (var item in lapTops)
                {
                    UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                    flpDanhMucLapTop.Controls.Add(user);
                }
            }
        }

        private void btnHP_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                string thuongHieu = "TH1";
                List<LapTop> lapTops = new List<LapTop>();
                lapTops = db.LapTops.Where(p => p.ID_ThuongHieu == thuongHieu).ToList();
                flpDanhMucLapTop.Controls.Clear();
                foreach (var item in lapTops)
                {
                    UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                    flpDanhMucLapTop.Controls.Add(user);
                }
            }
        }

        private void btnLenovo_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                string thuongHieu = "TH4";
                List<LapTop> lapTops = new List<LapTop>();
                lapTops = db.LapTops.Where(p => p.ID_ThuongHieu == thuongHieu).ToList();
                flpDanhMucLapTop.Controls.Clear();
                foreach (var item in lapTops)
                {
                    UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                    flpDanhMucLapTop.Controls.Add(user);
                }
            }
        }

        private void btnGigabyte_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                string thuongHieu = "TH8";
                List<LapTop> lapTops = new List<LapTop>();
                lapTops = db.LapTops.Where(p => p.ID_ThuongHieu == thuongHieu).ToList();
                flpDanhMucLapTop.Controls.Clear();
                foreach (var item in lapTops)
                {
                    UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                    flpDanhMucLapTop.Controls.Add(user);
                }
            }
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                string thuongHieu = "TH5";
                List<LapTop> lapTops = new List<LapTop>();
                lapTops = db.LapTops.Where(p => p.ID_ThuongHieu == thuongHieu).ToList();
                flpDanhMucLapTop.Controls.Clear();
                foreach (var item in lapTops)
                {
                    UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                    flpDanhMucLapTop.Controls.Add(user);
                }
            }
        }

        private void btnMsi_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                string thuongHieu = "TH6";
                List<LapTop> lapTops = new List<LapTop>();
                lapTops = db.LapTops.Where(p => p.ID_ThuongHieu == thuongHieu).ToList();
                flpDanhMucLapTop.Controls.Clear();
                foreach (var item in lapTops)
                {
                    UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                    flpDanhMucLapTop.Controls.Add(user);
                }
            }
        }

        private void btnMac_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                string thuongHieu = "TH7";
                List<LapTop> lapTops = new List<LapTop>();
                lapTops = db.LapTops.Where(p => p.ID_ThuongHieu == thuongHieu).ToList();
                flpDanhMucLapTop.Controls.Clear();
                foreach (var item in lapTops)
                {
                    UserControlSanPhamLaptop user = new UserControlSanPhamLaptop(ConvertBinaryDataToImage(item.HinhAnh), item.TenLapTop, ChuyenRam(item.ID_Ram), ChuyenCPU(item.ID_CPU));
                    flpDanhMucLapTop.Controls.Add(user);
                }
            }
        }
        #endregion


    }
}
