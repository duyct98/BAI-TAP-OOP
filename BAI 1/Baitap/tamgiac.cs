using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    internal class tamgiac
    {
        private double ma, mb, mc;

        public double getma()
        {
            return ma;
        }
        public void setma(double ma)
        {   
            if(ma > 0)
            {
                this.ma = ma;
            }
            
        }
        public double getmb()
        {
            return mb;
        }
        public void setmb(double mb)
        {
            if (mb > 0)
            {
                this.mb = mb;
            }
        }
        public double getmc()
        {
            return mc;
        }
        public void setmc(double mc)
        {
            if (mc > 0)
            {
                this.ma = mb;
            }
        }
        public tamgiac()
        {
            this.ma = 0;
            this.mb = 0;
            this.mc = 0;
        }
        public tamgiac(double ma, double mb, double mc)
        {
            if (ma <= 0 || mb <= 0 || mc <= 0 || ma + mb <= mc || ma + mc <= mb || mc + mb <= ma)
            {
                ma = 0;
                mb = 0;
                mc = 0;
            }
            else
            {
                this.ma = ma;
                this.mb = mb;
                this.mc = mc;
            }
        }
        public double chuvi()
        {
            return ma+mb+mc;
        }
        public double dientich()
        {   
            double p=(ma+mb+mc)/2;
            return Math.Sqrt(p*(p-ma)*(p-mb)*(p-mc));
        }
        public string kieutamgiac()
        {
            if(mc > 0 && mb > 0 && ma > 0)
            {
                if (ma == mb && ma == mc)
                {
                    return "tam giac deu";
                }
                else if (ma == mb || ma == mc || mc == mb)
                {
                    return "tam giac can";
                }
                else if (ma + mb > mc || ma + mc > mb || mc + mb > ma)
                {
                    return "tam giac thuong";
                }
            }
            return "khong phai tam giac";
            
                
        }
        public void info()
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-25}{4,-10}{5,-10}", ma,mb,mc,kieutamgiac(),chuvi(),Math.Round(dientich(), 2));
        }
    }
}
