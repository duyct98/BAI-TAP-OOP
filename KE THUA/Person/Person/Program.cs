using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person.addPerson("zsd", 10);
            Person.addPerson("csd", 50);
            Person.addPerson("dsd", 40);
            Person.addPerson("asd", 45);
            Person.addPerson("asd", 10);
            Person.list.Sort();

            Person.list.ForEach(data => Console.WriteLine(data.toString()));
            Console.ReadKey();
        }
    }
}
