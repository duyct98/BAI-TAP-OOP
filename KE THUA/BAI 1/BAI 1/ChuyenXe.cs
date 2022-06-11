using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1
{
    internal class ChuyenXe
    {
        private string maSoChuyen;
        private string hoTen;
        private int soTuyen;
        private double doanhThu;
        private int soXe;
        

        public string MaSoChuyen { get => maSoChuyen; set => maSoChuyen = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int SoXe { get => soXe; set => soXe = value; }
        

        public double DoanhThu { get => doanhThu; set => doanhThu = value; }
        public int SoTuyen { get => soTuyen; set => soTuyen = value; }
    }
}
