using QuanLyBanDongHo.Model;
using System;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyBanDongHo
{
    public partial class Form7 : Form
    {
        XMLFile XmlFile = new XMLFile();
        XmlDocument XDoc;
        string tenKhach = "", tenNV = "";
        int tongtien = 0, soluong = 0;

        public Form7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadTable()
        {
            gvDonHang.Rows.Clear();
            XDoc = XmlFile.getXmlDocument("HoaDonNhapXuats.xml");
            XmlNodeList nodeListDH = XDoc.SelectNodes("/HoaDonNhapXuats/HoaDonNhapXuat");
            XDoc = XmlFile.getXmlDocument("NhanViens.xml");
            XmlNodeList nodeListNV = XDoc.SelectNodes("/NhanViens/NhanVien");
            XDoc = XmlFile.getXmlDocument("KhachHangs.xml");
            XmlNodeList nodeListKH = XDoc.SelectNodes("/KhachHangs/KhachHang");
            XDoc = XmlFile.getXmlDocument("ChiTietHoaDons.xml");
            XmlNodeList nodeListCTHD = XDoc.SelectNodes("/ChiTietHoaDons/ChiTietHoaDon");
            foreach (XmlNode x in nodeListDH)
            {
                if(x.ChildNodes[3].InnerText.Equals("X"))
                {
                    tongtien = 0;
                    soluong = 0;
                    foreach (XmlNode a in nodeListKH)
                        if ((a.ChildNodes[0].InnerText).Equals(x.ChildNodes[2].InnerText))
                            tenKhach = a.ChildNodes[1].InnerText;
                    foreach (XmlNode b in nodeListNV)
                        if ((b.ChildNodes[0].InnerText).Equals(x.ChildNodes[1].InnerText))
                            tenNV = b.ChildNodes[1].InnerText;
                    foreach (XmlNode c in nodeListCTHD)
                    {
                        if ((c.ChildNodes[0].InnerText).Equals(x.ChildNodes[0].InnerText))
                        {
                            tongtien += int.Parse(c.ChildNodes[3].InnerText);
                            soluong += int.Parse(c.ChildNodes[2].InnerText);
                        }
                    }
                    gvDonHang.Rows.Add(x.ChildNodes[0].InnerText, tenKhach, tenNV, soluong, tongtien);
                }
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
