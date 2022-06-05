using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BAI_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Nhap so luong list: ");
            List.setList(Convert.ToInt32(Console.ReadLine()));
            List.add(new CongNhan(1, "Tran", "A", 300));
            List.add(new CongNhan(2, "Nguyen", "B", 100));
            List.add(new CongNhan(3, "Pham", "C", 900));
            Menu.menu();
            Menu.luaChon();
            Menu.run();
            do
            {
                Menu.luaChon();
                Console.Clear();
                Menu.menu();
                Menu.run();
            }
            while (Menu.luachon != 0);


        }
    }
}
