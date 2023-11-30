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
    public partial class UserControlSanPhamLaptop : UserControl
    {
        public UserControlSanPhamLaptop()
        {
            InitializeComponent();
        }

        public UserControlSanPhamLaptop(Image HinhAnh, string TenLaptop, string Ram, string CPU)
        {
            InitializeComponent();
            ptbHinhAnh.Image = HinhAnh;
            lblTenLaptop.Text = TenLaptop;
            lblRam.Text = Ram;
            lblCPU.Text = CPU;
        }
    }
}
