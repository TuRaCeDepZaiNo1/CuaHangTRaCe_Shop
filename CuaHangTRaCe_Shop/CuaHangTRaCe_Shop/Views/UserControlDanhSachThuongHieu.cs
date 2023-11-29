using CuaHangTRaCe_Shop.DataBase;
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
    public partial class UserControlDanhSachThuongHieu : UserControl
    {
        public UserControlDanhSachThuongHieu()
        {
            InitializeComponent();
        }

        private void UserControlDanhSachThuongHieu_Load(object sender, EventArgs e)
        {
            using(var db = new TRaCe_Shop())
            {
                foreach (var item in db.ThuongHieus) 
                {
                    UserControlThuongHieu user = new UserControlThuongHieu(ConvertBinaryDataToImage(item.HinhAnh),item.TenThuongHieu);
                    flpDanhSachThuongHieu.Controls.Add(user);
                }
            }
        }

        public void fillTimKiem(string TenTH)
        {
            using(var db = new TRaCe_Shop())
            {
                var search = db.ThuongHieus.Where(p => p.TenThuongHieu == TenTH).FirstOrDefault();
                if (search != null)
                {
                    flpDanhSachThuongHieu.Controls.Clear();
                    UserControlThuongHieu user = new UserControlThuongHieu(ConvertBinaryDataToImage(search.HinhAnh), search.TenThuongHieu);
                    flpDanhSachThuongHieu.Controls.Add(user);
                }  
            }
        } 

        public void fillAll()
        {
            using (var db = new TRaCe_Shop())
            {
                flpDanhSachThuongHieu.Controls.Clear();
                foreach (var item in db.ThuongHieus)
                {
                    UserControlThuongHieu user = new UserControlThuongHieu(ConvertBinaryDataToImage(item.HinhAnh), item.TenThuongHieu);
                    flpDanhSachThuongHieu.Controls.Add(user);
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
    }
}
