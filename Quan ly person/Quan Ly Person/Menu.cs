using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Person
{
    internal class Menu
    {
        private static int luachon;

        public static void menu()
        {
            Console.WriteLine("---------- Menu --------");
            Console.WriteLine("1. add person.");
            Console.WriteLine("2. Remove person.");
            Console.WriteLine("3. Show person list.");
            Console.WriteLine("4. Update info person.");
            Console.WriteLine("0. Exit");
            Console.WriteLine("---------- Menu --------");
        }
        public static int select()
        {
            
            string name;
            int age,code;
            
                Console.Write("Nhap lua chon: ");
                luachon = Convert.ToInt32(Console.ReadLine());

                {
                    switch (luachon)
                    {
                        case 1:
                        Console.Write("Nhap ma so: ");
                        code = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap ten: ");
                        name = Console.ReadLine();

                        Console.Write("Nhap tuoi: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        PersonList.addPerson(new Person(code,name, age));
                        
                        break;

                        case 2:
                        Console.WriteLine("{0,10}{1,20}{1,20}", "Ma so", "Ten", "Tuoi");
                        if (PersonList.list.Count == 0)
                        {
                            Console.WriteLine("\nDanh sach trong !!! khong co data de xoa\n");
                        }
                        else
                        {
                            for (int i = 0; i < PersonList.list.Count; i++)
                            {
                                PersonList.list[i].info();
                            }
                            Console.Write("\nNhap ma so can xoa: ");
                            int codeRemove = Convert.ToInt32(Console.ReadLine());
                            PersonList.remove(codeRemove);
                        }
                        
                       
                        break;

                        case 3:
                        Console.WriteLine("{0,10}{1,20}{1,20}", "Ma so", "Ten","Tuoi");
                        if (PersonList.list.Count == 0)
                        {
                            Console.WriteLine("\nDanh sach trong !!!\n");
                        }
                        for (int i = 0; i < PersonList.list.Count; i++)
                        {
                            PersonList.list[i].info();
                        }
                        return 1;
                        case 4:

                        Console.WriteLine("{0,10}{1,20}{1,20}", "Ma so", "Ten", "Tuoi");
                        if (PersonList.list.Count == 0)
                        {
                            Console.WriteLine("\nDanh sach trong !!! khong co data de update\n");
                        }
                        else
                        {
                            Console.WriteLine("Nhap code person can update: ");
                            PersonList.update(Convert.ToInt32(Console.ReadLine()));
                        }


                        
                        break;
                        case 0:
                        Console.Clear();
                        Console.WriteLine("\nGoodbye see you again \n");
                        return 0;

                    }
                }
            return 1;

        }

    }
}
