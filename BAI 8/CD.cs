using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_8
{
    internal class CD
    {
        private int maCD;
        private float gia;
        private int soBaiHat;
        private string tuaCD = "Chua xac dinh";
        public CD(int maCD, float gia, int soBaiHat, string tuaCD)
        {
            MaCD = maCD;
            Gia = gia;
            SoBaiHat = soBaiHat;
            TuaCD = tuaCD;
            
        }

        public string TuaCD { get => tuaCD; set => tuaCD = value; }
        
        public int SoBaiHat { get => soBaiHat; set => soBaiHat = value; }
        public int MaCD { get => maCD; set => maCD = value; }
        public float Gia { get => gia; set => gia = value; }
        public string info()
        {
            return string.Format("{0,10}{1,15}{2,15}{3,10}", MaCD, TuaCD, SoBaiHat, Gia);
        }
    }
}
