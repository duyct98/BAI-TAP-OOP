using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_12
{
    internal class ListHV
    {
                
        public static List<HocVien> listHV = new List<HocVien>();

        public static void DSHV()
        {
            Console.WriteLine("------DANH SACH HOC VIEN TRONG TRUNG TAM-----");
            Console.WriteLine("{0,-20}{1,10}{2,20}", "Ho va ten", "Dia chi", "Sdt");
            for (int i = 0; i < ListKH.listKH[i].listHVDK.Count; i++)
            {
                Console.WriteLine("{0,-20}{1,10}{2,20}", ListHV.listHV[i].HoTen, ListHV.listHV[i].DiaChi, ListHV.listHV[i].SoDienThoai);
            }
        }


    }
}
