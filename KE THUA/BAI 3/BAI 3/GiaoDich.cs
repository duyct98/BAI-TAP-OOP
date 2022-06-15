using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3
{
    abstract internal class GiaoDich: IGiaoDich
    {
        public string MaGiaoDich { get => maGiaoDich; set => maGiaoDich = value; }
        public DateTime NgayGiaoDich { get => ngayGiaoDich; set => ngayGiaoDich = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
        private string maGiaoDich;
        private DateTime ngayGiaoDich;
        private double donGia;
        private int soLuong;
        private double thanhTien;

        public static List<Tien> Tien = new List<Tien>();
        public static List<Vang> Vang = new List<Vang>();

        public abstract string info();

               
        
        
    }
}
