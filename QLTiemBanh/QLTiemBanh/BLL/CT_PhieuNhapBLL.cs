using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTiemBanh.DAL;
using System.Data;

namespace QLTiemBanh.BLL
{
    class CT_PhieuNhapBLL
    {
        Dal dal = new Dal();
       
        public DataTable SelectCTPN()
        {
            String sql = "Select CT_PhieuNhap.maPN,CT_PhieuNhap.maNL,tenNL,tenDVT,donGiaNL,soLuongN from CT_PhieuNhap " +
                "inner join PhieuNhap on CT_PhieuNhap.maPN=PhieuNhap.maPN inner join NguyenLieu on CT_PhieuNhap.maNL=NguyenLieu.maNL";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SelectHD()//lay ra ma hoa don ra cbb
        {
            String sql = "Select * from PhieuNhap";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SelectNL()//lay ra ma nguye lieun ra cbb
        {
            String sql = "Select * from NguyenLieu";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertCTPN(String mpn, String mnl, float sln,float dg)
        {
            String sql = "INSERT INTO CT_PhieuNhap VALUES('" + mpn + "','" + mnl + "',"
                + sln + ","+dg+")";

            dal.ExecNonQuery(sql);
        }
        public void UpdateCTPN(String mpn, String mnl, float sln, float dg)
        {
            String sql = "UPDATE CT_PhieuNhap SET soLuongN=" + sln + ", donGiaNL="
                + dg + " WHERE maPN='" + mpn + "' and maNL='"+mnl+"'";

            dal.ExecNonQuery(sql);
        }
        public void DeleteCTPN(String mpn, String mnl)
        {
            String sql = "DELETE CT_PhieuNhap WHERE maPN='" + mpn + "' and maNL='" + mnl + "'";
            dal.ExecNonQuery(sql);
        }
        public DataTable TimCTPN(string mapn )
        {
            String sql = "Select CT_PhieuNhap.maPN,CT_PhieuNhap.maNL,tenNL,tenDVT,donGiaNL,soLuongN from CT_PhieuNhap " +
                "inner join PhieuNhap on CT_PhieuNhap.maPN=PhieuNhap.maPN inner join NguyenLieu on CT_PhieuNhap.maNL=NguyenLieu.maNL " +
                "where CT_PhieuNhap.maPN='"+mapn+"'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
