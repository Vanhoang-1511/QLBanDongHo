﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace QuanLyBanDongHo.Model
{
    class HoaDon
    {
        XMLFile XmlFile = new XMLFile();
        ChiTietSanPham cTNS = new ChiTietSanPham();
        String taoMaHoaDon(XmlDocument XDoc) {
     
            XmlNodeList temp = XDoc.SelectNodes("/HoaDonNhapXuats/HoaDonNhapXuat[last()]");

            String maHD = temp[0].ChildNodes[0].InnerText;
            maHD = ("000000" + (int.Parse(maHD.Substring(2))+1).ToString());
            maHD = "HD"+maHD.Substring(maHD.Length - 5);
            
         

            return maHD;
        }

        public Boolean add(XmlDocument XDocCTHD,List<XmlNode> nodeList,String maKhachHang,String l) {
            try {
                XmlDocument XDocChiTietSanPham = XmlFile.getXmlDocument("ChiTietSanPhams.xml");
                XmlDocument XDoc = XmlFile.getXmlDocument("HoaDonNhapXuats.xml");
                String maHD_new = taoMaHoaDon(XDoc);
                String maNV = Form1.form2.maNV;
                String maKH = maKhachHang;
                String loai = l;
                int CongTru = 1;
                if (l.Equals("N"))
                {
                    CongTru = 1;
                }
                else
                {
                    CongTru = -1;
                }

                
                XmlFile.themHoaDon(XDoc,maHD_new,maNV,maKH,loai);
                foreach (XmlNode x in nodeList) {
                    XmlNodeList temp = XDocChiTietSanPham.SelectNodes("/ChiTietSanPhams/ChiTietSanPham[maSP = '"+x.ChildNodes[0].InnerText+"']");
                    cTNS.setSoluong(int.Parse(x.ChildNodes[1].InnerText)*CongTru,temp[0]);

                    XmlNode maHoaDon = XDocCTHD.CreateElement("maHD");
                    maHoaDon.InnerText = maHD_new;
                    x.InsertBefore(maHoaDon,x.FirstChild);
                    XDocCTHD.DocumentElement.AppendChild(x);
                }
                XDocCTHD.Save("ChiTietHoaDons.xml");
                XDocChiTietSanPham.Save("ChiTietSanPhams.xml");
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public void ThemHoaDon(DataGridView dataGridView1,String maKHachDD,String loai)
        {
            List<XmlNode> nodeList = new List<XmlNode>();
            XmlDocument XDoc = XmlFile.getXmlDocument("ChiTietHoaDons.xml");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                XmlElement node = XDoc.CreateElement("ChiTietHoaDon");

                XmlElement maSP = XDoc.CreateElement("maSP");

                Console.WriteLine(dataGridView1.Rows[i].Cells[6].Value.ToString() + "maSP");

                maSP.InnerText = dataGridView1.Rows[i].Cells[6].Value.ToString();


                XmlElement soLuong = XDoc.CreateElement("soLuong");

                soLuong.InnerText = dataGridView1.Rows[i].Cells[3].Value.ToString();
                XmlElement donGia = XDoc.CreateElement("DonGia");
                donGia.InnerText = dataGridView1.Rows[i].Cells[4].Value.ToString(); ;

                node.AppendChild(maSP);
                node.AppendChild(soLuong);
                node.AppendChild(donGia);
                nodeList.Add(node);
            }
            HoaDon hoaDon = new HoaDon();
            hoaDon.add(XDoc, nodeList, maKHachDD, loai);
        }



    }
}
