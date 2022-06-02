using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_8
{
    internal class CDList
    {
        public static CD[] list = new CD[2];
        public static void setList(int n)
        {
            list = new CD[n];
        }
          

        public static int count=-1;
        public static void add(CD data)
        {   
            int check = 0;
            
            if(count+1 < list.Length)
            {
                for (int i = 0; i <= count; i++)
                {
                    if (list[i].MaCD == data.MaCD) { check = 1; }
                }



                if (check == 1)
                {
                    Console.WriteLine("Them CD false !!!");
                }
                else
                {
                    count++;
                    list[count] = data;
                }
            }
            else Console.WriteLine("Them CD false !!!");






        }
        public static int tinhSoLuong()
        {
            return count;
        }
        public static float tongGiaCD()
        {
            float sum=0;
            for(int i = 0; i <= count; i++)
            {
                sum=sum+list[i].Gia;
            }
            return sum;
        }
        public static void info()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("                     DANH SACH CD                    ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("{0,10}{1,15}{2,15}{3,10}", "Ma CD", "Tua CD", "SO Bai Hat", "Gia");
            for (int i = 0; i <= count; i++)
            {                
                Console.WriteLine(list[i].info());
            }
        }
    }
}
