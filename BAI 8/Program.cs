using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Nhap kich thuoc List: ");
            CDList.setList(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(CDList.list.Length);
            do
            {
                Menu.menu();
                Menu.luaChon();
                Menu.run();
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                
            }
            while ( Menu.luachon != 0);
            

            Console.ReadKey();
        }
    }
}
