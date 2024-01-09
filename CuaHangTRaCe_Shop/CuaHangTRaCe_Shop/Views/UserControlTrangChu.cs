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
    public partial class UserControlTrangChu : UserControl
    {

        public UserControlTrangChu()
        {
            InitializeComponent();
        }

        #region Button_DanhMuc

        public void btnGaming_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                this.Hide();
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

                if (mainForm != null)
                {
                    
                }
            }
        }

        private void btnMacbook_Click(object sender, EventArgs e)
        {

        }

        private void btnMongNhe_Click(object sender, EventArgs e)
        {

        }

        private void btnDoHoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSangTrong_Click(object sender, EventArgs e)
        {

        }

        private void btnChuot_Click(object sender, EventArgs e)
        {

        }

        private void btnBanPhim_Click(object sender, EventArgs e)
        {

        }

        private void btnLoa_Click(object sender, EventArgs e)
        {

        }

        private void btnCapSac_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiPhone_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
