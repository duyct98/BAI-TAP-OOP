using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check=false;
            int a=0;
            do
            {
                Console.Write("nhap a (10<a<100): ");
                try
                {

                    a = Convert.ToInt32(Console.ReadLine());
                    check = true;
                }
                catch (Exception) { }
                
            }
            while (check!=true&&a>=100||a<=10);
            Console.ReadKey();

        }
    }
}
