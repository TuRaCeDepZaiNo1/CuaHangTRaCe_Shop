namespace CuaHangTRaCe_Shop.Views
{
    partial class UserControlThuongHieu
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
            this.lblThuongHieu = new System.Windows.Forms.Label();
            this.btnThuongHieu = new System.Windows.Forms.Button();
            this.ptbThuongHieu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThuongHieu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThuongHieu
            // 
            this.lblThuongHieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThuongHieu.Location = new System.Drawing.Point(0, 166);
            this.lblThuongHieu.Name = "lblThuongHieu";
            this.lblThuongHieu.Size = new System.Drawing.Size(220, 28);
            this.lblThuongHieu.TabIndex = 1;
            this.lblThuongHieu.Text = "label1";
            this.lblThuongHieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThuongHieu
            // 
            this.btnThuongHieu.AutoSize = true;
            this.btnThuongHieu.Location = new System.Drawing.Point(0, 199);
            this.btnThuongHieu.Name = "btnThuongHieu";
            this.btnThuongHieu.Size = new System.Drawing.Size(220, 41);
            this.btnThuongHieu.TabIndex = 2;
            this.btnThuongHieu.Text = "Xem Chi Tiết";
            this.btnThuongHieu.UseVisualStyleBackColor = true;
            this.btnThuongHieu.Click += new System.EventHandler(this.btnThuongHieu_Click);
            // 
            // ptbThuongHieu
            // 
            this.ptbThuongHieu.Location = new System.Drawing.Point(33, 15);
            this.ptbThuongHieu.Name = "ptbThuongHieu";
            this.ptbThuongHieu.Size = new System.Drawing.Size(156, 147);
            this.ptbThuongHieu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbThuongHieu.TabIndex = 0;
            this.ptbThuongHieu.TabStop = false;
            // 
            // UserControlThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnThuongHieu);
            this.Controls.Add(this.lblThuongHieu);
            this.Controls.Add(this.ptbThuongHieu);
            this.Name = "UserControlThuongHieu";
            this.Size = new System.Drawing.Size(220, 240);
            ((System.ComponentModel.ISupportInitialize)(this.ptbThuongHieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbThuongHieu;
        private System.Windows.Forms.Label lblThuongHieu;
        private System.Windows.Forms.Button btnThuongHieu;
    }
}
