using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Baitap
{
    internal class Program
    {
        public static void nhap(sinhvien data)
        {   

            Console.Write("Nhap ma SV: ");
            int a = Convert.ToInt32(Console.ReadLine());
            data.setmaSV(a);
            while (a < 0)
            {
                Console.Write("Nhap lai ma SV: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Nhap ten SV: ");
            data.setname(Console.ReadLine());
            Console.Write("Nhap diem LT: ");
            data.setLT(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Nhap diem TH: ");
            data.setTH(Convert.ToDouble(Console.ReadLine()));
        }
        public static void xuatDSSV(sinhvien sv1, sinhvien sv2, sinhvien sv3)
        {
            Console.WriteLine("{0,-10}{1,-30}{2,-10}{3,-10}{4,-10}", "Ma SV", "Ho Ten", "Diem LT", "Diem TH", "Diem TB");
            sv1.info();
            sv2.info();
            sv3.info();
        }
        static void Main1(string[] args)
        {

            toado toado = new toado();
            toado.setx(2);
            toado.sety(3);
            toado.settentd("toa do 1");

            Console.WriteLine(toado.info());
            toado toado1 = new toado();
            toado1.sety(3);
            Console.WriteLine(toado1.info());

            
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            sinhvien sv1 = new sinhvien(name:"Nguyen Van A",maSV:1,LT:3,TH:5);
            sinhvien sv2 = new sinhvien(name: "Nguyen Thi B",maSV: 2, LT: 9, TH: 5);
            sinhvien sv3 = new sinhvien();

            xuatDSSV(sv1, sv2, sv3);

            nhap(sv3);

            xuatDSSV(sv1, sv2, sv3);
            Console.ReadKey();

        }

        

        
        
         
    }
}
