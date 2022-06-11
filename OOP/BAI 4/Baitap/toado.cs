using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Baitap
{
    
    internal class toado
    {
        private int x;
        private int y;
        private string tentd;
        public int getx()
        {
            return x;
        }
        public void settentd(string tentd)
        {
            this.tentd = tentd;
        }
        public toado()
        {
            this.x = 0;
            this.y = 0;
            this.tentd = "toa do 0";
        }
        public string gettentd()
        {
            return tentd;
        }
        public void setx(int x)
        {
            this.x = x;
        }

        public int gety()
        {
            return y;
        }
        public void sety(int y)
        {
            this.y = y;
        }
        public string info()
        {
            return tentd + " (" + x + "," + y + ")";
        }
        


    }

}
        
    

