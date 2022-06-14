using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1
{
    abstract internal class ChuyenXe
    {
        private string maSoChuyen;
        private string hoTen;
        private int soTuyen;
        private double doanhThu;
        private int soXe;

        public static List<ChuyenXe> noiThanh = new List<ChuyenXe>();
        public static List<ChuyenXe> ngoaiThanh = new List<ChuyenXe>();

        public string MaSoChuyen { get => maSoChuyen; set => maSoChuyen = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int SoXe { get => soXe; set => soXe = value; }
        

        public double DoanhThu { get => doanhThu; set => doanhThu = value; }
        public int SoTuyen { get => soTuyen; set => soTuyen = value; }

        public abstract string info();
        
        public static double doanhThuNoiThanh()
        {
            double sum = 0;
            for (int i = 0; i < noiThanh.Count; i++)
            {
                sum = sum + noiThanh[i].DoanhThu;
            }
            return sum;
        }
        public static double doanhThuNgoaiThanh()
        {
            double sum = 0;
            for (int i = 0; i < ngoaiThanh.Count; i++)
            {
                sum = sum + ngoaiThanh[i].DoanhThu;
            }
            return sum;
        }
        public static void infoNoiThanh()
        {
            Console.WriteLine("\n ---------------------------CHUYEN XE NGOAI THANH---------------------------");
            Console.WriteLine(" {0,-20}{1,-20}{2,-10}{3,-10}{4,-10}", "Ma so chuyen", "Ho ten", "So xe", "So ngay", "Doanh thu");

            for (int i = 0; i < noiThanh.Count; i++)
            {
                Console.WriteLine(noiThanh[i].info());
                }
            Console.WriteLine("Tong doanh thu: {0:0,0 VND}", doanhThuNoiThanh());
        }
        public static void infoNgoaiThanh()
        {
            Console.WriteLine("\n ----------------------------CHUYEN XE NOI THANH----------------------------");
            Console.WriteLine(" {0,-20}{1,-20}{2,-10}{3,-10}{4,-10}", "Ma so chuyen", "Ho ten", "So xe", "So km", "Doanh thu");
            for (int i = 0; i < ngoaiThanh.Count; i++)
            {
                Console.WriteLine(ngoaiThanh[i].info());
                }
            Console.WriteLine("Tong doanh thu: {0:0,0 VND}", doanhThuNgoaiThanh());
        }


    }
}
