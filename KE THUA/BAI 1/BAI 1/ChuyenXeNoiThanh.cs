using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1
{
    internal class ChuyenXeNoiThanh : ChuyenXe
    {
        private int soKM;
        public int SoKM { get => soKM; set => soKM = value; }

        



        
        public ChuyenXeNoiThanh(string msc, string ht, int sx, int skm, double dt)
        {            
            MaSoChuyen = msc;
            HoTen = ht;
            SoTuyen = sx;            
            DoanhThu = dt;
            SoKM = skm;
            
        }

        

        

        public override string info()
        {
            return string.Format(" {0,-20}{1,-20}{2,-10}{3,-10:0,0}{4,-10:0,0 VND}", MaSoChuyen, HoTen, SoTuyen, SoKM, DoanhThu);

        }
    }
}
