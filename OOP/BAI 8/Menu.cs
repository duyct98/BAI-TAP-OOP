using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_8
{
    internal class Menu
    {
        public static void menu()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("                         MENU                        ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1. Them CD.");
            Console.WriteLine("2. Tinh so luong CD.");
            Console.WriteLine("3. Tinh tong gia thanh cac CD.");
            Console.WriteLine("4. Thong tin cua toan bo CD");
            Console.WriteLine("5. Sap xep danh sach tang dan theo gia CD.");
            Console.WriteLine("6. Sap xep danh sach tang dan theo tua CD.");
            Console.WriteLine("0. Exit !!!");

        }
        public static int luachon;
        public static void luaChon()
        {
            Console.Write("Nhap lua chon: ");
            
            luachon=Convert.ToInt32(Console.ReadLine());

        }
        public static void run()
        {   
            
            switch (luachon)
            {
                case 1:
                    /* Console.Write("Nhap ma CD: ");
                     int maCD = Convert.ToInt32(Console.ReadLine());
                     Console.Write("Nhap gia CD: ");
                     float gia = Convert.ToInt64(Console.ReadLine());
                     Console.Write("Nhap so bai hat trong CD: ");
                     int soBaiHat = Convert.ToInt32(Console.ReadLine());
                     Console.Write("Nhap tua CD: ");
                     string  tuaCD = Console.ReadLine();
                     CDList.add(new CD(maCD,gia,soBaiHat,tuaCD));*/

                    CDList.add(new CD(2, 222, 11, "asdas"));
                    CDList.add(new CD(6, 322, 292, "bsdas"));
                    CDList.add(new CD(9, 022, 252, "asdas"));
                    CDList.add(new CD(1, 122, 212, "zsdas"));
                    CDList.add(new CD(0, 922, 262, "gsdas"));
                    break;
                case 2:
                    Console.WriteLine(CDList.tinhSoLuong());
                    break;
                case 3:
                    Console.WriteLine(CDList.tongGiaCD());
                    break;
                case 4:
                    CDList.info();
                    break;
                case 5:
                    for(int i = 0; i < CDList.count; i++)
                    {
                        if (CDList.list[i].Gia > CDList.list[i + 1].Gia)
                        {
                            CD listtemp = null;
                            listtemp = CDList.list[i];
                            CDList.list[i] = CDList.list[i + 1];
                            CDList.list[i + 1] = listtemp;
                        }
                        
                    }
                    break;
                case 6:
                    for(int i = 0; i < CDList.count; i++)
                    {
                        if (string.Compare(CDList.list[i].TuaCD,CDList.list[i + 1].TuaCD)>0)
                        {
                            CD listtemp = null;
                            listtemp = CDList.list[i];
                            CDList.list[i] = CDList.list[i + 1];
                            CDList.list[i + 1] = listtemp;
                        }
                    }
                    break;
            }

        }
    }
}
