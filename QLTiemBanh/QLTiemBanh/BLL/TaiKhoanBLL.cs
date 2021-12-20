using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTiemBanh.DAL;
using QLTiemBanh.DTO;
using System.Data;
namespace QLTiemBanh.BLL

{
    class TaiKhoanBLL
    {
        Dal dal = new Dal();
        private List<TaiKhoan> ToList(DataTable dt)
        {
            List<TaiKhoan> results = new List<TaiKhoan>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan user = new TaiKhoan();
                user.TenTK = "";
                user.MatKhau = "";
                user.HoTen = "";
                user.DienThoai = "";
                user.TenTK = dt.Rows[0].ItemArray[0].ToString();
                user.MatKhau = dt.Rows[i].ItemArray[1].ToString();
                user.HoTen = dt.Rows[i].ItemArray[2].ToString();
                user.DienThoai = dt.Rows[i].ItemArray[3].ToString();
                 
                results.Add(user);
            }
            return results;
        }
        public TaiKhoan FindOne(string username, string password)
        {
            string sql = "select * from TaiKhoan where tenTK = '" + username
                + "' and matKhau = '" + password + "'";
            DataTable dt = dal.GetTable(sql);

            return ToList(dt).Count != 0 ? ToList(dt)[0] : null;
        }
    }
}
