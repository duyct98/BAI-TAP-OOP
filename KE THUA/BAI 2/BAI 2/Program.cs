using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sach.sachGiaoKhoa.Add(new SachGiaoKhoa("001", new DateTime(2022, 1, 20), 10000, 10, "Nguyen Van A", "moi"));
            Sach.sachGiaoKhoa.Add(new SachGiaoKhoa("002", new DateTime(2021, 2, 2), 20000, 15, "Nguyen Van B", "cu"));
            Sach.sachGiaoKhoa.Add(new SachGiaoKhoa("002", new DateTime(2021, 9, 2), 5200, 9, "aa", "moi"));
            Sach.sachGiaoKhoa.Add(new SachGiaoKhoa("002", new DateTime(2022, 2, 2), 35000, 5, "aa", "cu"));

            Sach.sachThamKhao.Add(new SachThamKhao("001", new DateTime(2019, 4, 4), 15000, 15, "Nguyen Van D", 10000));
            Sach.sachThamKhao.Add(new SachThamKhao("002", new DateTime(2020, 5, 5), 25000, 5, "Nguyen Van C", 20000));

            SachGiaoKhoa.infoSGK();
            SachThamKhao.infoSTK();
            SachGiaoKhoa.timSachTheoNhaXuatban();
            Console.ReadKey();
        }
    }
}
