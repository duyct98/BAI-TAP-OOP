using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_7
{
    internal class HinhTron
    {

        private ToaDo tam;
        private double banKinh;
        public double tinhChuVi()
        {
            return banKinh*2 * 3.14;
        }
        public double tinhDienTich()
        {
            return banKinh * banKinh * 3.14;
        }
        public HinhTron(ToaDo tam,double banKinh)
        {
            this.tam = tam;
            this.banKinh = banKinh;
        }
        public void setTam(float x,float y)
        {
            this.tam.setx(x);
            this.tam.sety(y);
        }
        public ToaDo getTam()
        {
            return this.tam;
        }
        public void setBanKinh(double banKinh)
        {
            this.banKinh = banKinh;
        }
        public double getBanKinh()
        {
            return this.banKinh;
        }
        public void info()
        {
            Console.WriteLine("Hinh tron co tam O({0},{1}) voi ban kinh {2} co dien tich va chu vi lan luot la {3:0.000} va {4:0.200}", getTam().getx(), getTam().gety(),getBanKinh(),tinhDienTich(),tinhChuVi());
        }
    }
}
