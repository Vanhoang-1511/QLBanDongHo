using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using QuanLyBanDongHo.Model;

namespace QuanLyBanDongHo
{
    public partial class Form3 : Form
    {
        XMLFile XmlFile = new XMLFile();
        XmlNodeList nodeListDM;
        XmlNodeList nodeListCTSP;
        int stt = 0;
        public Form3()
        {
            InitializeComponent();
        }



        private void buttonInHoaDon_Click(object sender, EventArgs e)
        {
            stt = 0;
            HoaDon hd = new HoaDon();

            hd.ThemHoaDon(dataGridView1, textBoxNhaCungCap.Text,"N");
   
            MessageBox.Show("Thêm Sản Phẩm Thành Công", "Thông Báo");
            dataGridView1.Rows.Clear();


        }

        private void Form3_Load(object sender, EventArgs e)
        {   
            DanhMucSanPham DMSP = new DanhMucSanPham();
            nodeListDM = DMSP.getListMD();
            foreach (XmlNode x in nodeListDM)
            {
                comboBoxLoaiNS.Items.Add(x.ChildNodes[1].InnerText);
            
            }
        }

        private void comboBoxTenNongSan_SelectedIndexChanged(object sender, EventArgs e)
        {
   

        }

        private void comboBoxLoaiNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChiTietSanPham CTSP = new ChiTietSanPham();
                nodeListCTSP = CTSP.getListName();
                String maSP = "";
                comboBoxTenNongSan.Items.Clear();
                foreach (XmlNode x in nodeListDM)
                {
                    if(comboBoxLoaiNS.SelectedItem != null)
                        if (x.ChildNodes[1].InnerText.Equals(comboBoxLoaiNS.SelectedItem.ToString()))
                            maSP = x.ChildNodes[0].InnerText;
                }

                foreach (XmlNode x in nodeListCTSP)
                {
                    if (x.ChildNodes[4].InnerText.Equals(maSP))
                        comboBoxTenNongSan.Items.Add(x.ChildNodes[1].InnerText + " " + x.ChildNodes[0].InnerText);
                }
            }
            catch { }
          
        }

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {
            comboBoxLoaiNS.SelectedIndex = comboBoxLoaiNS.Items.IndexOf(dataGridView1.CurrentRow.Cells[2].FormattedValue.ToString());
            comboBoxTenNongSan.SelectedIndex = comboBoxTenNongSan.Items.IndexOf(dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString() + dataGridView1.CurrentRow.Cells[6].FormattedValue.ToString());
            textBoxDonGia.Text = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
            textBoxSoLuong.Text = dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNhaCungCap.Text.Equals(""))
                {
                    int a = int.Parse(textBoxNhaCungCap.Text);
                }
                int soLuong = int.Parse(textBoxSoLuong.Text);
                int donGia = int.Parse(textBoxDonGia.Text);
                int tong = soLuong * donGia;
                dataGridView1.Rows.Add(++stt, comboBoxTenNongSan.SelectedItem.ToString().Substring(0, comboBoxTenNongSan.SelectedItem.ToString().Length - 7), comboBoxLoaiNS.SelectedItem.ToString(), soLuong, donGia, tong,
                    
                comboBoxTenNongSan.SelectedItem.ToString().Substring(comboBoxTenNongSan.SelectedItem.ToString().Length-7));
                textBoxSoLuong.Text = "";
                textBoxDonGia.Text = "";
            }
            catch {

                MessageBox.Show("Thêm Nông Sản Thất Bại", "Thông Báo");
            }
       
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
