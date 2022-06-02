using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Person
{
    internal class Person
    {
        private string name;
        private int age;
        private int code;
        public void setcode(int code)
        {
            this.code = code;
        }
        public int getcode()
        {
            return this.code;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }
        public int getage()
        {
            return this.age;
        }
        public void setage(int age)
        {
            this.age = age;
        }
        public Person (int code,string name , int age)
        {
            this.name = name;
            this.age = age; 
            this.code = code;
        }
        public void info()
        {
            Console.WriteLine("{0,10}{1,20}{1,20}", getcode(), getname(),getage());
        }
    }
}
