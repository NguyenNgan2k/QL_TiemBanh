using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanh.DTO
{
    class NguyenLieu
    {
        private string maNL;
        private string tenNL;
        private DateTime tenDVT;
        private float soLuongC;
        
         
        public NguyenLieu(string maNL, string tenNL, DateTime tenDVT,float soLuongC)
        {
            this.MaNL = maNL;
            this.TenNL = tenNL;
            this.TenDVT = tenDVT;
            this.soLuongC = soLuongC;
        }

        public string MaNL { get => maNL; set => maNL = value; }
        public string TenNL { get => tenNL; set => tenNL = value; }
        public DateTime TenDVT { get => tenDVT; set => tenDVT = value; }
        public float SoLuongC { get => soLuongC; set => soLuongC = value; }
    }
}
