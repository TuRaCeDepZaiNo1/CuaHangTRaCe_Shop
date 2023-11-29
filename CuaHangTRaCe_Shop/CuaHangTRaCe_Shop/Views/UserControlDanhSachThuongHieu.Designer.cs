namespace CuaHangTRaCe_Shop.Views
{
    partial class UserControlDanhSachThuongHieu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcThuongHieu = new System.Windows.Forms.TabControl();
            this.tpDanhSachThuongHieu = new System.Windows.Forms.TabPage();
            this.flpDanhSachThuongHieu = new System.Windows.Forms.FlowLayoutPanel();
            this.tpChiTietThuongHieu = new System.Windows.Forms.TabPage();
            this.tcThuongHieu.SuspendLayout();
            this.tpDanhSachThuongHieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcThuongHieu
            // 
            this.tcThuongHieu.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcThuongHieu.Controls.Add(this.tpDanhSachThuongHieu);
            this.tcThuongHieu.Controls.Add(this.tpChiTietThuongHieu);
            this.tcThuongHieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcThuongHieu.ItemSize = new System.Drawing.Size(335, 25);
            this.tcThuongHieu.Location = new System.Drawing.Point(0, 0);
            this.tcThuongHieu.Name = "tcThuongHieu";
            this.tcThuongHieu.SelectedIndex = 0;
            this.tcThuongHieu.Size = new System.Drawing.Size(955, 710);
            this.tcThuongHieu.TabIndex = 0;
            // 
            // tpDanhSachThuongHieu
            // 
            this.tpDanhSachThuongHieu.Controls.Add(this.flpDanhSachThuongHieu);
            this.tpDanhSachThuongHieu.Location = new System.Drawing.Point(4, 4);
            this.tpDanhSachThuongHieu.Name = "tpDanhSachThuongHieu";
            this.tpDanhSachThuongHieu.Padding = new System.Windows.Forms.Padding(3);
            this.tpDanhSachThuongHieu.Size = new System.Drawing.Size(947, 677);
            this.tpDanhSachThuongHieu.TabIndex = 0;
            this.tpDanhSachThuongHieu.Text = "Danh Sách Thương Hiệu";
            this.tpDanhSachThuongHieu.UseVisualStyleBackColor = true;
            // 
            // flpDanhSachThuongHieu
            // 
            this.flpDanhSachThuongHieu.AutoScroll = true;
            this.flpDanhSachThuongHieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDanhSachThuongHieu.Location = new System.Drawing.Point(3, 3);
            this.flpDanhSachThuongHieu.Name = "flpDanhSachThuongHieu";
            this.flpDanhSachThuongHieu.Size = new System.Drawing.Size(941, 671);
            this.flpDanhSachThuongHieu.TabIndex = 0;
            // 
            // tpChiTietThuongHieu
            // 
            this.tpChiTietThuongHieu.Location = new System.Drawing.Point(4, 4);
            this.tpChiTietThuongHieu.Name = "tpChiTietThuongHieu";
            this.tpChiTietThuongHieu.Padding = new System.Windows.Forms.Padding(3);
            this.tpChiTietThuongHieu.Size = new System.Drawing.Size(947, 677);
            this.tpChiTietThuongHieu.TabIndex = 1;
            this.tpChiTietThuongHieu.Text = "Chi tiết thương hiệu";
            this.tpChiTietThuongHieu.UseVisualStyleBackColor = true;
            // 
            // UserControlDanhSachThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tcThuongHieu);
            this.Name = "UserControlDanhSachThuongHieu";
            this.Size = new System.Drawing.Size(955, 710);
            this.Load += new System.EventHandler(this.UserControlDanhSachThuongHieu_Load);
            this.tcThuongHieu.ResumeLayout(false);
            this.tpDanhSachThuongHieu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcThuongHieu;
        private System.Windows.Forms.TabPage tpDanhSachThuongHieu;
        private System.Windows.Forms.TabPage tpChiTietThuongHieu;
        private System.Windows.Forms.FlowLayoutPanel flpDanhSachThuongHieu;
    }
}
