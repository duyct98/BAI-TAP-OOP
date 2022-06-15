using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3
{
    internal class Tien : GiaoDich, ITien, IGiaoDich
    {
        private double tiGia;
        private string loaiTien;

        public string LoaiTien { get => loaiTien; set => loaiTien = value; }
        public double TiGia { get => tiGia; set => tiGia = value; }

        public Tien(string maGiaoDich, DateTime ngayGiaoDich, double donGia, int soLuong, string loaiTien)
        {
            MaGiaoDich = maGiaoDich;
            NgayGiaoDich = ngayGiaoDich;
            DonGia = donGia;
            SoLuong = soLuong;
            TiGia = 23000;
            LoaiTien = loaiTien;
            if (string.Compare(LoaiTien, "Euro") == 0)
            {
                TiGia = 24000;
            }
            if (string.Compare(LoaiTien, "VND") == 0)
            {
                ThanhTien = SoLuong * DonGia;
            }
            else ThanhTien = SoLuong * DonGia * TiGia;

        }
        public static void GiaoDich(Tien data)
        {
            Tien.Add(data);
        }
        public static double tongTien()
        {
            double sum = 0;
            for (int i = 0; i < Tien.Count; i++)
            {
                sum = sum + Tien[i].ThanhTien;
            }
            return sum;
        }
        public override string info()
        {
            return string.Format("{0,-10}{1,10}{2,15:0,0}{3,15}{4,15}{5,20}{6,20:0,0 VND}", MaGiaoDich, NgayGiaoDich.ToString("dd/MM/yyyy"), DonGia, SoLuong, TiGia, LoaiTien, ThanhTien);
        }
        public static void fullInfo()
        {
            Console.WriteLine("--------------------------------  GIAO DICH TIEN  ------------------------------------");
            Console.WriteLine("{0,-10}{1,10}{2,15}{3,15}{4,15}{5,20}{6,20}", "Ma GD", "Ngay nhap", "Don gia", "So luong", "Ti gia", "Loai Tien", "Thanh tien");
            for (int i = 0; i < Tien.Count; i++)
            {
                Console.WriteLine(Tien[i].info());

            }
            Console.WriteLine("Tong thanh tien: {0:0,0 VND}", tongTien());
        }


    }
}
