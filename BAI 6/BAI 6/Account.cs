using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_6
{
    internal class Account
    {
        public long accountNumber;
        public string name;
        public double balance;
        public readonly double RATE=0.035;
        public Account(long accountNumber, string name, double balance)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.balance = balance;
            
        }
        public Account(long accountNumber, string name)
        {
            this.accountNumber=accountNumber;
            this.name = name;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }
        public void setaccountNumber(long accountNumber)
        {
            this.accountNumber = accountNumber;
        }
        public long getaccountNumber()
        {
            return this.accountNumber;
        }
        public void setbalance(double balance)
        {
            this.balance = balance;

        }
        public double getbalance()
        {
            return this.balance;
        }
        public bool deposit(double amount)
        {
            if (amount > 0)
            {
                setbalance(getbalance() + amount);
                return true;
            }
            else
                return false;
        }
        public bool withdraw(double amount,double fee)
        {
            if (amount > 0&&fee+amount<getbalance())
            {
                setbalance(getbalance() - amount);
                return true;
            }
            else
                return false;
        }
        public void addInterrest()
        {
            setbalance(getbalance()+getbalance()*RATE);
        }
        public bool transfer(Account acc, double amount)
        {   
            if(amount > 0)
            {
                acc.setbalance(acc.getbalance() + amount);
                return true;
            }
            else return false ;
        }
        public void info()
        {
           
            Console.WriteLine(string.Format(new CultureInfo("en-AU"), "{0,0}{1,20}{2,20:C}", getaccountNumber(), getname(), getbalance()));
        }       

        }
    }


