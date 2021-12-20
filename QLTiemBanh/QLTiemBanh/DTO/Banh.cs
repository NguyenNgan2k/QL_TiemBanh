using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanh.DTO
{
    class Banh
    {
        private string maBanh;
        private string tenBanh;
        private string dVT;
        private float donGia;

        public string MaBanh { get => maBanh; set => maBanh = value; }
        public string TenBanh { get => tenBanh; set => tenBanh = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public string DVT { get => dVT; set => dVT = value; }

        public Banh()
        {

        }

        public Banh(string maBanh,string tenBanh,string dvt, float donGia )
        {
            this.maBanh = maBanh;
            this.tenBanh = tenBanh;
            this.dVT = dvt;
            this.donGia = donGia;
        }
    }
}
