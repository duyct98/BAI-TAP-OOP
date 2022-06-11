using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    internal class xe
    {
        private string chuxe,loaixe;
        private long dungtich;
        private long trigiaxe;
        private double thue;

        public xe(string chuxe,string loaixe,long dungtich,long trigiaxe)
        {
            this.chuxe = chuxe; ;
            this.loaixe = loaixe;
            if (trigiaxe >= 0)
            {
                this.trigiaxe = trigiaxe;

            }
            else
            {
                Console.Write("Nhap lai tri gia xe: ");
                settrigiaxe(Convert.ToInt64(Console.ReadLine()));
            }

            if (dungtich >= 0)
            {
                this.dungtich = dungtich;

            }
            else
            {
                Console.Write("Nhap lai dung tich xe: ");
                setdungtich(Convert.ToInt64(Console.ReadLine()));
            }
            if (dungtich < 100) 
            {
                this.thue = 0.01;
            }
            else if(dungtich > 200||dungtich <= 200)
            {
                this.thue = 0.02;
            }
            else if (dungtich > 200)
            {
                this.thue = 0.05;
            }
        }
        public void setchuxe(string chuxe)
        {
            this.chuxe=chuxe;
        }
        public string getchuxe()
        {
            return chuxe;
        }
        public void setloaixe(string loaixe)
        {
            
            this.loaixe = loaixe;
        }
        public string getloaixe()
        {
            return loaixe;
        }
        public void settrigiaxe(long trigiaxe)
        {
            if (trigiaxe >= 0)
            {
                this.trigiaxe = trigiaxe;

            }
            else
            {
                Console.Write("Nhap lai tri gia xe: ");
                settrigiaxe(Convert.ToInt64(Console.ReadLine()));
            }
                
        }
        public long gettrigiaxe()
        {
            return trigiaxe;
        }
        public void setdungtich(long dungtich)
        {
            if (dungtich >= 0)
            {
                this.dungtich = dungtich;

            }
            else
            {
                Console.Write("Nhap lai dung tich xe: ");
                setdungtich(Convert.ToInt64(Console.ReadLine()));
            }
        }
        public long getdungtich()
        {
            
            return dungtich;
        }
        public void info()
        {
            Console.WriteLine("{0,-20}{1,-20}{2,20}{3,20:0,0}{4,20:,0}", chuxe,loaixe,dungtich+"Cc",trigiaxe,thue*trigiaxe);
        }
        
    }
}
