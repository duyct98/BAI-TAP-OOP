using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //add học viên
            ListHV.listHV.Add(new HocVien("nguyen van a", "sg", "0147"));
            ListHV.listHV.Add(new HocVien("nguyen van b", "sg", "8147"));
            ListHV.listHV.Add(new HocVien("nguyen van c", "sg", "9147"));
            ListHV.listHV.Add(new HocVien("nguyen van d", "sg", "7147"));
            // add khóa học
            ListKH.listKH.Add(new KhoaHoc("game", new DateTime(2022, 9, 9), new DateTime(2023, 11, 9)));
            ListKH.listKH.Add(new KhoaHoc("dev", new DateTime(2011, 9, 9), new DateTime(2022, 11, 9)));
            ListKH.listKH.Add(new KhoaHoc("code", new DateTime(2005, 9, 9), new DateTime(2007, 11, 9)));
            ListKH.listKH.Add(new KhoaHoc("art", new DateTime(2022, 9, 9), new DateTime(2025, 11, 9)));

            // add học viên vào khóa học
            ListKH.listKH[0].add(ListHV.listHV[0]);
            ListKH.listKH[1].add(ListHV.listHV[0]);
            ListKH.listKH[2].add(ListHV.listHV[0]);

            ListKH.listKH[1].add(ListHV.listHV[1]);
            ListKH.listKH[3].add(ListHV.listHV[1]);
            
            //luu dữ liệu khóa học vào học viên
            ListHV.listHV[0].KhoaHoc.Add(ListKH.listKH[0]);
            ListHV.listHV[0].KhoaHoc.Add(ListKH.listKH[1]);
            ListHV.listHV[0].KhoaHoc.Add(ListKH.listKH[2]);

            ListHV.listHV[1].KhoaHoc.Add(ListKH.listKH[1]);
            ListHV.listHV[1].KhoaHoc.Add(ListKH.listKH[3]);



            while (true)
            {
                Menu.menu();
                Menu.LC();// nhap lua chon
                if (Menu.LuaChon == 0) 
                {
                    Console.Clear();
                    Console.Write("GOOD BYE !!!");
                    Console.ReadKey();
                    break;
                }                
                Menu.run();             
                
            }
            

            
        }
    }
}
