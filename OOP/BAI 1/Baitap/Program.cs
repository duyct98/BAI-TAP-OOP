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

            toado toado = new toado();
            toado.setx(2);
            toado.sety(3);
            toado.settentd("toa do 1");

            Console.WriteLine(toado.info());
            toado toado1 = new toado();
            toado1.sety(3);
            Console.WriteLine(toado1.info());

            
            Console.ReadKey();
        }
        

        

        
        
         
    }
}
