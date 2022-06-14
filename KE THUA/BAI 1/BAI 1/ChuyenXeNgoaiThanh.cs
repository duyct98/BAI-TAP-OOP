using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1
{
    internal class ChuyenXeNgoaiThanh:ChuyenXe
    {
        private int soNgayDiDuoc;

        public int SoNgayDiDuoc { get => soNgayDiDuoc; set => soNgayDiDuoc = value; }

        public ChuyenXeNgoaiThanh(string msc,string ht,int sx,int soNgayDiDuoc, double dt)
        {
            SoNgayDiDuoc = soNgayDiDuoc;
            MaSoChuyen = msc;
            HoTen = ht;
            SoTuyen = sx;
            SoNgayDiDuoc = soNgayDiDuoc;
            DoanhThu = dt;
            
            
        }


        public override string info()
        {
            return string.Format(" {0,-20}{1,-20}{2,-10}{3,-10}{4,-10:0,0 VND}", MaSoChuyen, HoTen, SoTuyen, SoNgayDiDuoc, DoanhThu);

        }

        
    }
}
