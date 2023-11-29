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
    public partial class UserControlThuongHieu : UserControl
    {
        public UserControlThuongHieu()
        {
            InitializeComponent();
        }

        public UserControlThuongHieu(Image image, string TenTH) 
        {
            InitializeComponent();

            ptbThuongHieu.Image = image;
            lblThuongHieu.Text = TenTH;
        }

        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
            if(lblThuongHieu.Text == "HP")
            {

            }
            else if (lblThuongHieu.Text == "ASUS")
            {

            }
            else if (lblThuongHieu.Text == "ACER")
            {

            }
            else if (lblThuongHieu.Text == "MACBOOK")
            {

            }
            else if (lblThuongHieu.Text == "GIGABYTE")
            {

            }
            else if (lblThuongHieu.Text == "DELL")
            {

            }
            else if (lblThuongHieu.Text == "LENOVO")
            {

            }
            else if (lblThuongHieu.Text == "MSI")
            {

            }
        }
    }
}
