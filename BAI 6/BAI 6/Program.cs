using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Account acc1 = new Account(72354, "Ted Murphy", 102.56);
            Account acc2 = new Account(69713, "Jane Smith", 40.56);
            Account acc3 = new Account(93757, "Edward Demsey", 759.32);
            acc1.deposit(25.85);
            acc2.deposit(500.00);
            acc2.withdraw(430.75,1.50);
            acc3.addInterrest();
            xuat();
            transfer(acc2, acc1, 100.00);
            xuat();



            void xuat()
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("{0,0}{1,20}{2,20:C}", "STK", "Ten", "So du");
                Console.WriteLine("----------------------------------------------");
                acc1.info();
                acc2.info();
                acc3.info();
            }
            Console.ReadKey();
        }
        
        public static void transfer(Account sent, Account get, double monney)
        {
            
            if (sent.transfer(get, monney) == true)
            {
                sent.setbalance(sent.getbalance() - monney);
            }
        }
    }
}
