using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2
{
    internal class SachGiaoKhoa: Sach
    {
        private string tinhTrang;
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public SachGiaoKhoa(string maSach , DateTime ngayNhap,double donGia,int soLuong,string nhaXuatBan, string tinhTrang)
        {
            MaSach = maSach;
            NgayNhap = ngayNhap;
            DonGia = donGia;
            NhaXuatBan = nhaXuatBan;
            TinhTrang = tinhTrang;
            SoLuong = soLuong;
            if (tinhTrang == "moi") ThanhTien = soLuong * donGia;
            else if (tinhTrang == "cu") ThanhTien = soLuong * donGia * 0.5;

        }

        public override string info()
        {
            return String.Format("{0,-10}{1,10}{2,15:0,0}{3,15}{4,15}{5,20}{6,20:0,0 VND}", MaSach, NgayNhap.ToString("dd/MM/yyyy"),DonGia,SoLuong,NhaXuatBan,tinhTrang,ThanhTien);
        }
        public static double tongTien_SGK()
        {
            double sum = 0;
            for (int i = 0; i < sachGiaoKhoa.Count; i++)
            {
                sum = sum + sachGiaoKhoa[i].ThanhTien;
            }
            return sum;
        }
        public static void infoSGK()
        {
            Console.WriteLine("--------------------------------SACH GIAO KHOA------------------------------------");

            Console.WriteLine("{0,-10}{1,10}{2,15}{3,15}{4,15}{5,20}{6,20}", "Ma sach", "Ngay nhap", "Don gia", "So luong", "Nha xuat ban", "Tinh trang", "Thanh tien");

            for (int i = 0; i < sachGiaoKhoa.Count; i++)
            {
                Console.WriteLine(sachGiaoKhoa[i].info());
            }
            Console.WriteLine("Tong Tien : {0:0,0}", SachGiaoKhoa.tongTien_SGK());
        }
        public static void timSachTheoNhaXuatban()
        {
            Console.Write("Nhap ten NXB: ");
            string nhaXuatBan = Console.ReadLine();
            Console.WriteLine("--------------------------------  Nha Xuat Ban : {0}  ------------------------------------",nhaXuatBan);
            Console.WriteLine("{0,-10}{1,10}{2,15}{3,15}{4,15}{5,20}{6,20}", "Ma sach", "Ngay nhap", "Don gia", "So luong", "Nha xuat ban", "Tinh trang", "Thanh tien");

            for (int i = 0; i < sachGiaoKhoa.Count; i++)
            {
                if (string.Compare(sachGiaoKhoa[i].NhaXuatBan, nhaXuatBan) == 0)
                {
                    Console.WriteLine(sachGiaoKhoa[i].info());
                }
                
            }
        }
    }
}
