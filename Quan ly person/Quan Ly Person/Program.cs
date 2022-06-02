using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Menu.menu();
            while(Menu.select() == 1)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Menu.menu();
                
            }

            Console.ReadKey();
        }
    }
}
