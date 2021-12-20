using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTiemBanh.DAL;
using System.Data;

namespace QLTiemBanh.BLL
{
    class NguyenLieuBLL
    {
        Dal dal = new Dal();
        public DataTable SelectNL()
        {
            String sql = "Select * from NguyenLieu";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertNL(String mnl, String tnl, String dvt,float slc)
        {
            String sql = "INSERT INTO NguyenLieu VALUES('" + mnl + "',N'" + tnl + "','"
                + dvt + "',"+slc+")";

            dal.ExecNonQuery(sql);
        }
        public void UpdateNL(String mnl, String tnl, String dvt, float slc)
        {
            String sql = "UPDATE NguyenLieu SET tenNL=N'" + tnl + "', tenDVT=N'"
                + dvt + "',soLuongC=" + slc + " WHERE maNL='" + mnl + "'";

            dal.ExecNonQuery(sql);
        }
        public void DeleteNL(String mnl)
        {
            String sql = "DELETE NguyenLieu WHERE maNL='" + mnl + "'";
            dal.ExecNonQuery(sql);
        }
        public DataTable TimNL(string manl)
        {
            string sql = "select * from NguyenLieu where maNL ='" + manl + "' ";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
