using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Tien.GiaoDich(new Tien("001", new DateTime(2005, 10, 10), 100, 50, "USD"));
            Tien.GiaoDich(new Tien("002", new DateTime(2002, 11, 10), 50, 150, "Euro"));
            Tien.GiaoDich(new Tien("003", new DateTime(2002, 11, 10), 500000, 150, "VND"));
            Vang.GiaoDich(new Vang("001", new DateTime(2002, 11, 10), 500000,10, "9999"));
            Vang.GiaoDich(new Vang("002", new DateTime(2001, 6, 10), 500000, 10, "18K"));
            Vang.GiaoDich(new Vang("003", new DateTime(2001, 9, 1), 400000, 5, "SJC"));


            Tien.fullInfo();
            Vang.fullInfo();

            Console.ReadKey();
        }


    }
}
