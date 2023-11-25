using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CuaHangTRaCe_Shop.Views
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private async Task LoadUserDataAsync()
        {
            // Hiển thị ProgressBar
            ProgressBar1.Visible = true;

            // Thiết lập giá trị tối đa cho ProgressBar
            ProgressBar1.Maximum = 100;

            // Giả sử quá trình tải dữ liệu mất 5 giây
            for (int i = 0; i <= 100; i++)
            {
                // Giả lập việc tải dữ liệu
                await Task.Delay(50);

                // Cập nhật giá trị của ProgressBar
                ProgressBar1.Value = i;
                lblLoading.Text = i.ToString() + "%";
            }
            if(lblLoading.Text == "100%")
            {
                this.Hide();
            }
        }

        private async void Loading_LoadAsync(object sender, EventArgs e)
        {
            await LoadUserDataAsync();
        }
    }
}
