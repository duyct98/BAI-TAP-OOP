using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_11
{
    internal class Diem
    {
        private double toan,ly,hoa,van,anh;

        public double Toan { get => toan; set => toan = value; }
        public double Ly { get => ly; set => ly = value; }
        public double Hoa { get => hoa; set => hoa = value; }
        public double Van { get => van; set => van = value; }
        public double Anh { get => anh; set => anh = value; }
        public Diem(double toan, double ly, double hoa, double van, double anh)
        {
            Toan = toan;
            Ly = ly;
            Hoa = hoa;
            Van = van;
            Anh = anh;
        }

        public int ketQua()
        {
            if (diemTrungBinh() > 7& monDiemThapNhat()>=5)
            {
                return 2;
            }
            else if (diemTrungBinh() <= 7 & monDiemThapNhat() >= 5)
            {
                return 1;
            }
            else return 0;
        }
        public string stringKetQua()
        {
            if (diemTrungBinh() > 7 & monDiemThapNhat() >= 5)
            {
                return "Lam Luan Van";
            }
            else if (diemTrungBinh() <= 7 & monDiemThapNhat() >= 5)
            {
                return "Thi Tot Nghiep";
            }
            else return "Rot";
        }
        public double monDiemThapNhat()
        {
            double min = 10;
            if (min > Toan)min = Toan;            
            if(min > Hoa)min = Hoa;
            if (min > Ly) min = Ly;
            if (min > Van) min = Van;
            if (min > Anh) min = Anh;
            return min;
        }

        public double diemTrungBinh()
        {
            return (Toan + Ly + Hoa + Van + Anh) / 5;
        }
    }
    
    
}
