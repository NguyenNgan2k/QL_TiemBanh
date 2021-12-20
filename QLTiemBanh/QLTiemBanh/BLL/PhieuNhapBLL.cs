using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTiemBanh.DAL;
using System.Data;
namespace QLTiemBanh.BLL
{
    class PhieuNhapBLL
    {
        Dal dal = new Dal();
        public DataTable SelectPN()
        {
            String sql = "Select * from PhieuNhap";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertPN(String mpn, String ncc,DateTime nl)
        {
            String sql = "INSERT INTO PhieuNhap VALUES('" + mpn + "',N'" + ncc + "','"
                + nl.ToString("yyyy-MM-dd") + "')";

            dal.ExecNonQuery(sql);
        }
        public void UpdatePN(String mpn, String ncc, DateTime nl)
        {
            String sql = "UPDATE PhieuNhap SET nhaCC=N'" + ncc + "', ngayLap='"
                + nl.ToString("yyyy-MM-dd") + "' WHERE maPN='" + mpn + "'";

            dal.ExecNonQuery(sql);
        }
        public void DeletePN(String mpn)
        {
            String sql = "DELETE PhieuNhap WHERE maPN='" + mpn + "'";
            dal.ExecNonQuery(sql);
        }
        public DataTable TimPN(string mapn)
        {
            string sql = "select * from PhieuNhap where maPN ='"+mapn+"' ";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

    }
}
