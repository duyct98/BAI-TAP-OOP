using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_7
{
    internal class ToaDo
    {
        private string ten;
        private float x, y;
        public ToaDo(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public ToaDo()
        {
            this.x = 0;
            this.y = 0;
        }
        public void setx(float x)
        {
            this.x = x;
        }
        public float getx()
        {
            return this.x;
        }
        public float gety()
        {
            return this.y;
        }
        public  void sety(float y)
        {
            this.y = y;
        }
    }
}
