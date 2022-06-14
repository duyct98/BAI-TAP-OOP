using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2
{
    internal class SachThamKhao: Sach
    {
        private double thue;

        public double Thue { get => thue; set => thue = value; }

        public SachThamKhao(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, double thue)
        {
            MaSach = maSach;
            NgayNhap = ngayNhap;
            DonGia = donGia;
            NhaXuatBan = nhaXuatBan;
            Thue = thue;
            SoLuong = soLuong;
            ThanhTien = soLuong * donGia + Thue;
            
        }

        public override string info()
        {
            return String.Format("{0,-10}{1,10}{2,15:0,0}{3,15}{4,15}{5,20}{6,20:0,0 VND}", MaSach, NgayNhap.ToString("dd/MM/yyyy"), DonGia, SoLuong, NhaXuatBan, thue, ThanhTien);
        }
        public static double TB_STK()
        {
            double tb = 0;
            for (int i = 0; i < sachThamKhao.Count; i++)
            {
                tb = tb + sachThamKhao[i].DonGia / sachThamKhao[i].SoLuong;
            }
            return tb / sachThamKhao.Count;
        }
        public static double tongTien_STK()
        {
            double sum = 0;
            for (int i = 0; i < sachThamKhao.Count; i++)
            {
                sum = sum + sachThamKhao[i].ThanhTien;
            }
            return sum;
        }
        public static void infoSTK()
        {
            Console.WriteLine("--------------------------------SACH THAM KHAO------------------------------------");

            Console.WriteLine("{0,-10}{1,10}{2,15}{3,15}{4,15}{5,20}{6,20}", "Ma sach", "Ngay nhap", "Don gia", "So luong", "Nha xuat ban", "Thue", "Thanh tien");

            for (int i = 0; i < sachThamKhao.Count; i++)
            {
                Console.WriteLine(sachThamKhao[i].info());
            }
            Console.WriteLine("Trung binh don gia : {0:0,0 VND}", SachThamKhao.TB_STK());
            Console.WriteLine("Tong Tien : {0:0,0 VND}", SachThamKhao.tongTien_STK());

        }
    }
}
