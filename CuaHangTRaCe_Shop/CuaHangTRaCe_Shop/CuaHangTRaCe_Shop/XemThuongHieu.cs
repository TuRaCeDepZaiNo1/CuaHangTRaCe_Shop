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
    public partial class XemThuongHieu : Form
    {
        public XemThuongHieu()
        {
            InitializeComponent();
        }

        private void XemThuongHieu_Load(object sender, EventArgs e)
        {
            using(var db = new TRaCe_Shop())
            {
                var Result = from c in db.ThuongHieus select new {ID_Thương_Hiệu = c.ID_ThuongHieu, Tên_Thương_Hiệu = c.TenThuongHieu, Hình_Ảnh = c.HinhAnh};
                dgvThuongHieu.DataSource = Result.ToList();
            }
        }
    }
}
