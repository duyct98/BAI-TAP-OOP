using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person : IComparable<Person>
    {
        private int age;
        private string name;
        public static List<Person> list = new List<Person>();
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;            
        }

        internal string toString()
        {
            return string.Format("{0} {1}",Name, Age);
        }

        public static void addPerson(string name,int age)
        {
            list.Add(new Person(name,age));
        }

        public int CompareTo(Person other)
        {
            if(Age < other.Age)
            {
                return 1;
            }
            if (Age > other.Age)
            {
                return -1;
            }
            else
            return 0;
        }
        public void into()
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0}{1}",Name,Age);
            }
        }
    }
}
