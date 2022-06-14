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
            ChuyenXe.ngoaiThanh.Add(new ChuyenXeNgoaiThanh("001", "Nguyen van a", 96, 100, 15000000));
            ChuyenXe.ngoaiThanh.Add(new ChuyenXeNgoaiThanh("002", "Nguyen van b", 96, 25, 9000000));
            ChuyenXe.noiThanh.Add(new ChuyenXeNoiThanh("001", "Nguyen van a", 69, 1000, 15000000));
            ChuyenXe.noiThanh.Add(new ChuyenXeNoiThanh("002", "Nguyen thi b", 96, 900, 13000000));

            //xuat chuyyen xe
            ChuyenXe.infoNoiThanh();
            ChuyenXe.infoNgoaiThanh();

            Console.ReadKey();
        }
    }
}
