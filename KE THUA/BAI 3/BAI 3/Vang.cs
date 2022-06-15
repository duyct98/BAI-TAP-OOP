using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3
{
    internal class Vang : GiaoDich, IVang, IGiaoDich
    {
        private string LoaiVang { get; set; }

        public Vang(string maGiaoDich, DateTime ngayGiaoDich, double donGia, int soLuong, string loaiVang)
        {
            MaGiaoDich = maGiaoDich;
            NgayGiaoDich = ngayGiaoDich;
            DonGia = donGia;
            LoaiVang = loaiVang;
            SoLuong = soLuong;
            ThanhTien = SoLuong * DonGia;

        }

        public override string info()
        {
            return string.Format("{0,-10}{1,10}{2,15:0,0}{3,15}{4,15}{5,20:0,0 VND}", MaGiaoDich, NgayGiaoDich.ToString("dd/MM/yyyy"), DonGia, SoLuong, LoaiVang, ThanhTien);

        }
        public static void fullInfo()
        {
            Console.WriteLine("--------------------------------  GIAO DICH VANG  ------------------------------------");
            Console.WriteLine("{0,-10}{1,10}{2,15}{3,15}{4,15}{5,20}", "Ma GD", "Ngay nhap", "Don gia", "So luong", "Loai Vang", "Thanh tien");
            for (int i = 0; i < Vang.Count; i++)
            {
                Console.WriteLine(Vang[i].info());

            }
        }
        public static void GiaoDich(Vang data)
        {
            Vang.Add(data);
        }
    }
}
