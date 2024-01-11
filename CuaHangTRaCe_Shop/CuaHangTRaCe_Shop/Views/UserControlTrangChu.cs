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
                string loai = "Gaming";
                this.Hide();
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

                if (mainForm != null)
                {
                    mainForm.TimKiemLoai(loai);
                }
            }
        }

        private void btnMacbook_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                string loai = "Macbook";
                this.Hide();
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

                if (mainForm != null)
                {
                    mainForm.TimKiemLoai(loai);
                }
            }
        }

        private void btnMongNhe_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                string loai = "Mỏng nhẹ";
                this.Hide();
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

                if (mainForm != null)
                {
                    mainForm.TimKiemLoai(loai);
                }
            }
        }

        private void btnDoHoa_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                string loai = "Đồ họa, thiết kế";
                this.Hide();
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

                if (mainForm != null)
                {
                    mainForm.TimKiemLoai(loai);
                }
            }
        }

        private void btnSangTrong_Click(object sender, EventArgs e)
        {
            using (var db = new TRaCe_Shop())
            {
                string loai = "Sang trọng";
                this.Hide();
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

                if (mainForm != null)
                {
                    mainForm.TimKiemLoai(loai);
                }
            }
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
