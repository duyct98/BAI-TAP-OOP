using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_9
{
    internal class Menu
    {
        public static void menu()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("                         MENU                        ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1. Them CN.");
            Console.WriteLine("2. Xuat toan bo thong tin CN");
            Console.WriteLine("3. Tinh so luong CN.");
            Console.WriteLine("4. Xuat thong tin CN tren 200 san pham.");
            Console.WriteLine("5. Sap xep danh sach giam dan theo san pham.");
            Console.WriteLine("0. Exit !!!");

        }
        public static int luachon;
        public static void luaChon()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Nhap lua chon: ");
            luachon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------");


        }

        public static void run()
        {

            switch (luachon)
            {
                case 1:
                    // tu nhap

                    /*Console.Write("Nhap ma CN: ");
                    int maCN=Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap mHo: ");
                    string mHo = Console.ReadLine();
                    Console.Write("Nhap mTen: ");
                    string mTen = Console.ReadLine();
                    Console.Write("Nhap so san pham : ");
                    int mSoSP = Convert.ToInt32(Console.ReadLine());*/


                    // nhap san -- TEST
                    List.add(new CongNhan(2, "A", "B", 300));
                    List.add(new CongNhan(3, "A", "B", 100));
                    List.add(new CongNhan(4, "A", "B", 900));

                    break;
                case 2:
                    List.info();
                    break;
                case 3:
                    Console.WriteLine("So luong CN : " + List.count);
                    break;
                case 4:
                    List.CN_Tren_200_SP();
                    break;
                case 5:
                    List.sap_Xep_SP_Giam_Dan();
                    break;

            }

        }

    }
}
