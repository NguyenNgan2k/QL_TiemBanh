using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTiemBanh.DAL;
using System.Data;
namespace QLTiemBanh.BLL
{
    class HoaDonBLL
    {
        Dal dal = new Dal();
        public DataTable SelectHD()
        {
            String sql = "Select * from HoaDon";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertHD(String mhd, String tkh, DateTime nl)
        {
            String sql = "INSERT INTO HoaDon VALUES('" + mhd + "',N'" + tkh + "','"
                + nl.ToString("yyyy-MM-dd") + "')";

            dal.ExecNonQuery(sql);
        }
        public void UpdateHD(String mhd, String  tkh, DateTime nl)
        {
            String sql = "UPDATE HoaDon SET tenKH=N'" + tkh + "', ngayLapHD='"
                + nl.ToString("yyyy-MM-dd") + "' WHERE maHD='"+mhd+"'";

            dal.ExecNonQuery(sql);
        }
        public void DeleteHD(String mhd)
        {
            String sql = "DELETE HoaDon WHERE maHD='" + mhd + "'";
            dal.ExecNonQuery(sql);
        }
        public DataTable TimHD(string mahd)
        {
            string sql = "select * from HoaDon where maHD ='" + mahd + "' ";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

    }
}
