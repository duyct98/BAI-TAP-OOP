using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1
{
    internal class Program
    {
        static void Main(string[] args)
        {   //add chuyen xe
            ChuyenXeNgoaiThanh ngoaiThanh1 = new ChuyenXeNgoaiThanh("001","Nguyen van a",69,30,10000000);
            ChuyenXeNgoaiThanh ngoaiThanh2 = new ChuyenXeNgoaiThanh("002", "Nguyen van b", 96, 25, 9000000);
            ChuyenXeNoiThanh noiThanh1 = new ChuyenXeNoiThanh("001", "Nguyen van a", 69, 1000, 15000000);
            ChuyenXeNoiThanh noiThanh2 = new ChuyenXeNoiThanh("002", "Nguyen thi b", 96, 900, 13000000);


            //xuat chuyyen xe
            Console.WriteLine("\n ---------------------------CHUYEN XE NGOAI THANH---------------------------");
            Console.WriteLine(" {0,-20}{1,-20}{2,-10}{3,-10}{4,-10}", "Ma so chuyen", "Ho ten", "So xe", "So ngay", "Doanh thu");
            Console.WriteLine(ngoaiThanh1.info());
            Console.WriteLine(ngoaiThanh2.info());

            Console.WriteLine("\n ----------------------------CHUYEN XE NOI THANH----------------------------");
            Console.WriteLine(" {0,-20}{1,-20}{2,-10}{3,-10}{4,-10}", "Ma so chuyen", "Ho ten", "So xe", "So km", "Doanh thu");
            Console.WriteLine(noiThanh1.info());
            Console.WriteLine(noiThanh2.info());
            Console.ReadKey();
        }
    }
}
