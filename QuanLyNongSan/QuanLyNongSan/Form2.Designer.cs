namespace QuanLyNongSan
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonQLKhachHang = new System.Windows.Forms.Button();
            this.buttonLSThanhToan = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonXuatNS = new System.Windows.Forms.Button();
            this.buttonNhapNS = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BackgroundImage = global::QuanLyNongSan.Properties.Resources.bg042;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonQLKhachHang);
            this.panel1.Controls.Add(this.buttonLSThanhToan);
            this.panel1.Controls.Add(this.buttonCapNhat);
            this.panel1.Controls.Add(this.buttonXuatNS);
            this.panel1.Controls.Add(this.buttonNhapNS);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 355);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 104);
            this.panel2.TabIndex = 8;
            this.panel2.TabStop = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(201, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "Một chữ tín - Vạn niềm tin";
            // 
            // buttonQLNongSan
            // 
            
            // 
            // buttonQLKhachHang
            // 
            this.buttonQLKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonQLKhachHang.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.buttonQLKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonQLKhachHang.Location = new System.Drawing.Point(450, 121);
            this.buttonQLKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQLKhachHang.Name = "buttonQLKhachHang";
            this.buttonQLKhachHang.Size = new System.Drawing.Size(220, 51);
            this.buttonQLKhachHang.TabIndex = 6;
            this.buttonQLKhachHang.Text = "Quản lý khách hàng";
            this.buttonQLKhachHang.UseVisualStyleBackColor = false;
            this.buttonQLKhachHang.Click += new System.EventHandler(this.buttonQLKhachHang_Click);
            // 
            // buttonLSThanhToan
            // 
            this.buttonLSThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonLSThanhToan.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.buttonLSThanhToan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLSThanhToan.Location = new System.Drawing.Point(450, 272);
            this.buttonLSThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLSThanhToan.Name = "buttonLSThanhToan";
            this.buttonLSThanhToan.Size = new System.Drawing.Size(220, 51);
            this.buttonLSThanhToan.TabIndex = 5;
            this.buttonLSThanhToan.Text = "Lịch sử Thanh toán";
            this.buttonLSThanhToan.UseVisualStyleBackColor = false;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCapNhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCapNhat.Location = new System.Drawing.Point(450, 196);
            this.buttonCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(220, 51);
            this.buttonCapNhat.TabIndex = 4;
            this.buttonCapNhat.Text = "Cập nhật - Sao lưu Dữ liệu";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonXuatNS
            // 
            this.buttonXuatNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonXuatNS.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.buttonXuatNS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonXuatNS.Location = new System.Drawing.Point(88, 196);
            this.buttonXuatNS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXuatNS.Name = "buttonXuatNS";
            this.buttonXuatNS.Size = new System.Drawing.Size(213, 51);
            this.buttonXuatNS.TabIndex = 2;
            this.buttonXuatNS.Text = "Thanh toán";
            this.buttonXuatNS.UseVisualStyleBackColor = false;
            this.buttonXuatNS.Click += new System.EventHandler(this.buttonXuatNS_Click);
            // 
            // buttonNhapNS
            // 
            this.buttonNhapNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonNhapNS.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhapNS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNhapNS.Location = new System.Drawing.Point(88, 121);
            this.buttonNhapNS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNhapNS.Name = "buttonNhapNS";
            this.buttonNhapNS.Size = new System.Drawing.Size(213, 51);
            this.buttonNhapNS.TabIndex = 1;
            this.buttonNhapNS.Text = "Nhập Hàng";
            this.buttonNhapNS.UseVisualStyleBackColor = false;
            this.buttonNhapNS.Click += new System.EventHandler(this.buttonNhapNS_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::QuanLyNongSan.Properties.Resources.logo1;
            this.pictureBox8.Location = new System.Drawing.Point(77, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(105, 98);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 357);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Menu Chính ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQLKhachHang;
        private System.Windows.Forms.Button buttonLSThanhToan;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonXuatNS;
        private System.Windows.Forms.Button buttonNhapNS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}