using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Baitap
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            xe xe1 = new xe("Nguyen van a","Exciter",150,50000000);
            xe xe2 = new xe("Nguyen van b", "Satria", 150, 65000000);
            xe xe3 = new xe("Nguyen van c", "Lamborghini Huracan", 5200, 23000000000);
            Console.Write("Nhap tri gia xe {0}: ",xe1.getloaixe());
            xe1.settrigiaxe(Convert.ToInt64(Console.ReadLine()));
            Console.WriteLine("{0,-20}{1,-20}{2,20}{3,20}{4,20}", "Chu xe", "Loai xe", "Dung tich", "Tri gia xe", "Thue");
            xe1.info();
            xe2.info();
            xe3.info();
            Console.ReadKey();
        }
        
         
    }
}
