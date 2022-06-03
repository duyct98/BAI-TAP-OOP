using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_9
{
    internal class List
    {
        public static int count = 0;
        public static CongNhan[] list;

        public static void setList(int data)
        {


            list = new CongNhan[data];



        }
        public static void add(CongNhan data)
        {
            if (count < list.Length)
            {

                list[count] = data;
                count++;
                Console.WriteLine("Add successful !!!!");
            }
            else
                Console.WriteLine("Add false !!!!");

        }
        public static void info()
        {
            Console.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}", "Ma CN", "MHo", "MTen", "MSoSP", "Luong");
            for (int i = 0; i < count; i++)
            {

                Console.WriteLine(list[i].info());
            }
        }
        public static int soLuongCN()
        {
            return count;
        }
        public static void CN_Tren_200_SP()
        {
            Console.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}", "Ma CN", "MHo", "MTen", "MSoSP", "Luong");
            for (int i = 0; i < count; i++)
            {
                if (list[i].MSoSP > 200)
                {

                    Console.WriteLine(list[i].info());

                }

            }


        }
        public static void sap_Xep_SP_Giam_Dan()
        {
            CongNhan temp = null;
            for (int i = 0; i < count; i++)
            {
                for (int j = i; j < count; j++)

                    if (list[i].MSoSP < list[j].MSoSP)
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
            }
        }



    }
}
