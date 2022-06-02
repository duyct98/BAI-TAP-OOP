using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Person
{
    internal class PersonList
    {
       

        public static List<Person> list=new List<Person>();
        
        public static void addPerson(Person data)
        {

            list.Add(data);           


        }
        public static void remove(int a)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].getcode() == a)
                {
                    list.RemoveAt(i);
                }
            }
            
        }
        public static void update(int a)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getcode() == a)
                {
                    Console.Write("Nhap ma so: ");
                    int code = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap ten: ");
                    string name = Console.ReadLine();
                    Console.Write("Nhap tuoi: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Person temp = new Person(code, name, age);

                    Console.Write("Xac nhan thay doi thong tin (Y/N): ");
                    string check = Console.ReadLine();
                    if (check=="Y"||check == "y")
                    {
                        list[i] = temp;
                    }

                    
                }
            }
           

        }

    }
}
