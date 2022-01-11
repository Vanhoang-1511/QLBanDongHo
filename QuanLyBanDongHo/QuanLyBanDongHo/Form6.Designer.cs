namespace QuanLyBanDongHo
{
    partial class FormSaoLuuData
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonXML_SQL = new System.Windows.Forms.Button();
            this.buttonKhoiPhuc = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CSDL - SAO LƯU";
            // 
            // buttonXML_SQL
            // 
            this.buttonXML_SQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonXML_SQL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXML_SQL.Location = new System.Drawing.Point(265, 85);
            this.buttonXML_SQL.Name = "buttonXML_SQL";
            this.buttonXML_SQL.Size = new System.Drawing.Size(267, 44);
            this.buttonXML_SQL.TabIndex = 2;
            this.buttonXML_SQL.Text = "Sao lưu (XML - SQL)";
            this.buttonXML_SQL.UseVisualStyleBackColor = false;
            this.buttonXML_SQL.Click += new System.EventHandler(this.buttonXML_SQL_Click);
            // 
            // buttonKhoiPhuc
            // 
            this.buttonKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonKhoiPhuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKhoiPhuc.Location = new System.Drawing.Point(267, 227);
            this.buttonKhoiPhuc.Name = "buttonKhoiPhuc";
            this.buttonKhoiPhuc.Size = new System.Drawing.Size(263, 46);
            this.buttonKhoiPhuc.TabIndex = 4;
            this.buttonKhoiPhuc.Text = "Khôi phục dữ liệu (SQl - XML)";
            this.buttonKhoiPhuc.UseVisualStyleBackColor = false;
            this.buttonKhoiPhuc.Click += new System.EventHandler(this.buttonKhoiPhuc_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::QuanLyBanDongHo.Properties.Resources.logo1;
            this.pictureBox8.Location = new System.Drawing.Point(0, 60);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(259, 242);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // FormSaoLuuData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanDongHo.Properties.Resources.bg041;
            this.ClientSize = new System.Drawing.Size(556, 300);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.buttonKhoiPhuc);
            this.Controls.Add(this.buttonXML_SQL);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSaoLuuData";
            this.Text = "Hoàng Tuấn Luxyry Watch Store";
            this.Load += new System.EventHandler(this.FormSaoLuuData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonXML_SQL;
        private System.Windows.Forms.Button buttonKhoiPhuc;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}