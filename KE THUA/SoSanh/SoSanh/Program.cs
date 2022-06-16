using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point.addPoint(10,20);
            Point.addPoint(140, 220);
            Point.addPoint(103, 20);
            Point.addPoint(120, 10);
            Point.addPoint(160, 290);
            Point.info();
            Point.list.Sort();
            Point.info();  
            
            Console.ReadKey();
            }
    }
}
