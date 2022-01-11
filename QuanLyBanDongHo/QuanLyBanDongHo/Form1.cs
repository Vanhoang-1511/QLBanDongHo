using System;
using System.Windows.Forms;
using QuanLyBanDongHo.Model;

namespace QuanLyBanDongHo
{
    public partial class Form1 : Form
    {
        static public Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap DN = new DangNhap();
            String maNV = DN.Login(textBoxTenDN.Text, textBoxMatKhau.Text);
            if (!maNV.Equals(""))
            {
                form2 = new Form2();
                form2.maNV = maNV;
                form2.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo");
            }
            Console.WriteLine(DN.Login(textBoxTenDN.Text, textBoxMatKhau.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
    }
}
