using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2
{
    abstract internal class Sach
    {
        private string maSach,nhaXuatBan;
        private DateTime ngayNhap;
        private double donGia,thanhTien;
        private int soLuong;

        public static List<Sach> sachGiaoKhoa = new List<Sach>();
        public static List<Sach> sachThamKhao = new List<Sach>();

        public string MaSach { get => maSach; set => maSach = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public abstract string info();
        

        
    }
}
