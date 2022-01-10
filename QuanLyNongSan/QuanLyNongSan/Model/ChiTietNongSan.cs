using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace QuanLyNongSan.Model
{
    class ChiTietNongSan
    {

        XMLFile XmlFile = new XMLFile();
        public XmlNodeList getListName() {
            
            XmlDocument XDoc = XmlFile.getXmlDocument("ChiTietSanPhams.xml");

            return XDoc.SelectNodes("/ChiTietSanPhams/ChiTietSanPham");
        }

        public void setSoluong(int soLuongTraoDoi,XmlNode node) {
            
            node.ChildNodes[2].InnerText = (int.Parse(node.ChildNodes[2].InnerText)+ soLuongTraoDoi).ToString();
        }

    }
}
