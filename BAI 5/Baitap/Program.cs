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
            Console.WriteLine("________________________________________________________________________________________________________________");
            Console.WriteLine("{0,10}{1,20:0,0}{2,20:0,0}{3,20}{4,20}{5,15}", "Ma Hang", "Ten Hang", "Don gia", "Ngay san xuat", "Ngay het han", "Ghi chu");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            hangthucpham gao = new hangthucpham("001","Gao",100000,new DateTime(2018,7,10), new DateTime(2022, 07, 10));
            hangthucpham mi = new hangthucpham("002", "Mi", 5000, new DateTime(2018, 3, 1), new DateTime(2022, 09, 01));
            hangthucpham nuoc = new hangthucpham("003", "Nuoc", 10000, new DateTime(2017, 3, 1), new DateTime(2018, 9, 1));
            hangthucpham erro = new hangthucpham("", "Nuoc", 10000, new DateTime(2017, 3, 1), new DateTime(2018, 9, 1));

            gao.info();
            mi.info();
            nuoc.info();
            Console.ReadKey();
        }
        
         
    }
}
