using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanh.DTO
{
    class PhieuNhap
    {
        private string maPN;
        private string nhaCC;
        private DateTime ngayLap;

        public string MaPN { get => maPN; set => maPN = value; }
        public string NhaCC { get => nhaCC; set => nhaCC = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public PhieuNhap(string maPN,string nhaCC,DateTime ngayLap)
        {
            this.maPN = maPN;
            this.nhaCC = nhaCC;
            this.ngayLap = ngayLap;
        }
    }
}
