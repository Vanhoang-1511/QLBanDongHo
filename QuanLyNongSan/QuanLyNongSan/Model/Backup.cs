using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace QuanLyNongSan
{
    class BackUp
    {
        SqlConnection conn = new SqlConnection("Data Source=VZCOMPUTER\\SQLEXPRESS;Initial Catalog=BanDongHo;Persist Security Info=True;User ID=sa;Password=123");
        // Cái này là overload                             
        public void BackUpData()
        {
            BackUpData("DanhMucSanPham");
            BackUpData("KhachHang");
            BackUpData("ChiTietSanPham");
            BackUpData("ChiTietHoaDon");
            BackUpData("HoaDonNhapXuat");
            BackUpData("NhanVien");
        }
        String toString(XElement elm)
        {
            String result = "";
            foreach (XElement x in elm.Elements())
            {
                if (x == elm.LastNode)
                    result += "N'" + x.Value + "'";
                else
                {
                    result += "N'" + x.Value + "',";
                }
            }
            return "(" + result + "),\n";
        }

        // Cái này là overload    
        private void BackUpData(String XMLFileName)
        {
            XDocument XDoc = XDocument.Load(XMLFileName + "s.xml");
            Console.WriteLine(111111111);
            conn.Open();
            SqlCommand command;
            // Tạo chuỗi câu lệnh , Nếu dùng Console là sẽ thấy lệnh
            String query = "DELETE FROM " + XMLFileName + " \n insert into " + XMLFileName + " values\n";
            try
            {
                foreach (XElement x in XDoc.Descendants(XMLFileName))
                {
                    toString(x);
                    query += toString(x);
                }
                Console.WriteLine(query.Substring(0, query.Length - 2));
                // Tạo xong là chạy như bình thường như chạy 1 câu trong ssms thôi
                command = new SqlCommand(query.Substring(0, query.Length - 2), conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                // try catch để biết lỗi
                Console.WriteLine(e.Message);
                conn.Close();
            }
            //Console.Read();
        }

    }
}
