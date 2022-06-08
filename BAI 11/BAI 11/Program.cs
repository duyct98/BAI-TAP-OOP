using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListHV.list.Add(new HocVien("Nguyen Van a", 1998, new Diem(1, 2, 3, 4, 5)));
            ListHV.list.Add(new HocVien("Nguyen Van b", 1999, new Diem(5, 5, 5, 5, 5)));
            ListHV.list.Add(new HocVien("Nguyen Van c", 2000, new Diem(7, 7, 7, 9.5, 5)));
            ListHV.list.Add(new HocVien("Nguyen Van c", 2000, new Diem(7, 7, 7, 7, 5)));

            ListHV.info();
            Console.WriteLine("\nCo {0} hoc vien du dieu kien lam luan van.", ListHV.luanVan());
            Console.WriteLine("Co {0} hoc vien du dieu kien thi tot nghiep.",ListHV.thiTotNghiep());
            Console.WriteLine("Co {0} hoc vien rot.", ListHV.rot());
            
            Console.ReadKey();

        }
    }
}
