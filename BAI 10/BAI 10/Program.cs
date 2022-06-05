using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //add hang hoa
            Product catsrang = new Product("1111", "Catsrang", 70000);
            Product dogFood = new Product("9999", "Dog Food", 100000);
            Product meo = new Product("3333", "Meo", 2000000);
            Product cho = new Product("4444", "Cho", 5000000);
            Product qweqwez = new Product("9234", "Cqweqw", 500000);

            // tao hoa don
            Order Hd1 = new Order(1111, DateTime.Now);
            Order Hd2 = new Order(3333, DateTime.Now);

            //add hoa don 1
            Hd1.addLineItem(catsrang, 100);
            Hd1.addLineItem(meo, 2);
            Hd1.addLineItem(cho, 1);
            Hd1.addLineItem(dogFood, 1);

            //add hoa don 2
            Hd2.addLineItem(meo, 10);

            //in hoa don 
            Hd1.infoOrder();
            Hd2.infoOrder();           
            Console.ReadKey();
        }
    }
}
