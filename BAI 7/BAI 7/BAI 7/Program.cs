using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_7
{
    internal class Program
    {
        static void Main(string[] args)
        {               
            HinhTron ht1 = new HinhTron(new ToaDo(5,5), 10.5);

            ht1.info();
            
            Console.ReadKey();
        }
    }
}
