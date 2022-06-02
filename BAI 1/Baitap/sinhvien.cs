using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    internal class sinhvien
    {
        private int maSV;
        private string name;
        private double LT;

        private double TH;
        public sinhvien(int maSV,string name,double LT,double TH)
        {
            this.maSV = maSV;
            this.name = name;
            this.LT = LT;
            this.TH = TH;
            
            /*public void setmaSV(int maSV)
            {
                this.maSV = maSV;
            }
            public int getmaSV()
            {
                return maSV;
            }
            public void setname(string name)
            {
                this.name = name;
            }
            
            public string getname()
            {
                return name;
            }
            public void setLT(double LT)
            {
                this.LT = LT;
            }
            public double getLT()
            {
                return LT;
            }
            public void setTH(double TH)
            {
                this.TH = TH;
            }
            public double getTH()
            {
                return TH;
            }*/
        }




        public void info()
        {
            Console.WriteLine("{0,-10}{1,-30}{2,-10}{3,-10}{4,-10}", maSV,name,LT,TH,diemtb(LT,TH));
        }
        public void setmaSV(int maSV)
        {
            this.maSV = maSV;
        }
        public int getmaSV()
        {
            return maSV;
        }
        public void setname(string name)
        {
            this.name = name;
        }

        public string getname()
        {
            return name;
        }
        public void setLT(double LT)
        {
            this.LT = LT;
        }
        public double getLT()
        {
            return LT;
        }
        public void setTH(double TH)
        {
            this.TH = TH;
        }
        public double getTH()
        {
            return TH;
        }

        public sinhvien()
        {
            maSV = 0;
            name = "Chua co ten";
            LT = 0;
            TH = 0;
            
        }
        public double diemtb(double LT, double TH)
        {
            return (LT + TH) / 2;
        }




    }
}
