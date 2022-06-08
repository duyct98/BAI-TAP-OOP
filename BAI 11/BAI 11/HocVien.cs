using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_11
{
    internal class HocVien
    {
        private string hoTen;
        private int namSinh;
        private Diem diem;
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        internal Diem Diem { get => diem; set => diem = value; }

        public HocVien(string hoTen, int namSinh,Diem diem)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            Diem = diem;
        }
    }
}
