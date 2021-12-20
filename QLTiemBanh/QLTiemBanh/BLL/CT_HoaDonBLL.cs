using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTiemBanh.DAL;
using System.Data;
using QLTiemBanh.DTO;
namespace QLTiemBanh.BLL
{
    class CT_HoaDonBLL
    {
        Dal dal = new Dal();
        public DataTable SelectCTHD(string mhd)
        {
            String sql = "Select CT_HoaDon.maBanh,tenBanh,donGia,soLuongB,thanhTien from CT_HoaDon " +
                "inner join Banh on CT_HoaDon.maBanh=Banh.maBanh inner join HoaDon on CT_HoaDon.maHD=HoaDon.maHD where CT_HoaDon.maHD='" + mhd+"'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SelectHD()//lay ra ma hoa don ra cbb
        {
            String sql = "Select * from HoaDon";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SelectB()// lay ra ma banh ra cbb
        {
            String sql = "Select * from Banh";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertCTHD(String mpn, String mb, int slb,float tt)
        {
            String sql = "INSERT INTO CT_HoaDon VALUES('" + mpn + "',N'" + mb + "','"
                + slb + "','"+tt+"')";

            dal.ExecNonQuery(sql);
        }
        public Banh SelectB(String mb)//don gia de tinh tong tien
        {
            String sql = "select * from Banh where maBanh='"+mb+"'";
            DataTable dt = dal.GetTable(sql);
            
                Banh bn = new Banh();
                bn.MaBanh = dt.Rows[0].ItemArray[0].ToString();
                bn.TenBanh = dt.Rows[0].ItemArray[1].ToString();
                bn.DVT = dt.Rows[0].ItemArray[2].ToString();
                bn.DonGia = float.Parse(dt.Rows[0].ItemArray[3].ToString());
            return bn;      
        }
      
        public void DeleteCTHD(String mhd,string mab)
        {
            String sql = "DELETE CT_HoaDon WHERE maHD='" + mhd + "'and maBanh='"+mab+"'" ;
            dal.ExecNonQuery(sql);
        }
        

    }
}
