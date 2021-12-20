using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTiemBanh.DAL;
using System.Data;
namespace QLTiemBanh.BLL
{
    class BanhBLL
    {
        Dal dal = new Dal();
        public DataTable SelectB()
        {
            String sql = "Select * from Banh";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertB(String mb, String tb, String dvt, float dg)
        {
            String sql = "INSERT INTO Banh VALUES('" + mb + "',N'" + tb + "','"
                + dvt + "',"+dg+")";

            dal.ExecNonQuery(sql);
        }
        public void UpdateB(String mb, String tb, String dvt, float dg)
        {
            String sql = "UPDATE Banh SET tenBanh=N'" + tb + "', dVT=N'"
                +dvt+ "',donGia="+dg+" WHERE maBanh='" + mb + "'";

            dal.ExecNonQuery(sql);
        }
        public void DeleteB(String mb)
        {
            String sql = "DELETE Banh WHERE maBanh='" + mb + "'";
            dal.ExecNonQuery(sql);
        }
        public DataTable TimB(string mb)
        {
            string sql = "select * from Banh where maBanh ='" + mb + "' ";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
