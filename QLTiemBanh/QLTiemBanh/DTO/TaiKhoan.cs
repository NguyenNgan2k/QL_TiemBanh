using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanh.DTO
{
    class TaiKhoan
    {
        private string tenTK;
        private string matKhau;
        private string hoTen;
        private string dienThoai;

        public string TenTK { get => tenTK; set => tenTK = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public TaiKhoan()
        {

        }
        public TaiKhoan(string tenTK, string matKhau, string hoTen, string dienThoai)
        {
            this.tenTK = TenTK;
            this.matKhau = matKhau;
            this.hoTen = hoTen;
            this.dienThoai = dienThoai;
        }
    }
}
