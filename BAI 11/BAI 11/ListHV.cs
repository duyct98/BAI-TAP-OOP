using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_11
{
    internal class ListHV
    {
        public static List<HocVien> list = new List<HocVien>();
        
        public static int luanVan()
        {
            int count=0;
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].Diem.ketQua() == 2)count++;
            }
            return count;
        }
        public static int thiTotNghiep()
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Diem.ketQua() == 1) count++;
            }
            return count;
        }
        public static int rot()
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Diem.ketQua() == 0) count++;
            }
            return count;
        }
        public static void info()
        {

            Console.WriteLine("----------------DANH SACH HOC VIEN-----------------\n");
            Console.WriteLine("{0,-20}{1,10}{2,20}", "Ho Ten", "Nam Sinh", "Ket Qua");
            

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0,-20}{1,10}{2,20}", list[i].HoTen, list[i].NamSinh, list[i].Diem.stringKetQua());
            }
            
        }
    }
}
