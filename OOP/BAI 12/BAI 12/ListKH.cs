using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_12
{

    internal class ListKH
    {
        
        public static List<KhoaHoc> listKH = new List<KhoaHoc>();

        public static void DSKH()
        {
            Console.WriteLine("---------DANH SACH KHOA HOC---------");
            Console.WriteLine("{0,-20}{1,10}{2,20}{3,20}", "Ten KH", "Ngay mo", "Ngay dong","Thoi gian(ngay)");
            for (int i = 0; i < ListKH.listKH.Count; i++)
            {
                Console.WriteLine(ListKH.listKH[i].info());
            }
        }
        public static void DSHVDK(string KH)
        {
            Console.WriteLine("-----DANH SACH HOC VIEN TRONG KHOA HOC-----");
            Console.WriteLine("{0,-20}{1,10}{2,20}", "Ho va ten", "Dia chi", "Sdt");
            for (int i = 0; i < ListKH.listKH.Count; i++)
            {
                if(string.Compare(KH,ListKH.listKH[i].TenKH)==0)
                {
                    for(int j=0; j< ListKH.listKH[i].listHVDK.Count; j++)
                    {
                        Console.WriteLine("{0,-20}{1,10}{2,20}", ListKH.listKH[i].listHVDK[j].HoTen, ListKH.listKH[i].listHVDK[j].DiaChi, ListKH.listKH[i].listHVDK[j].SoDienThoai);
                    }
                    break;
                }
                
            }
        }
    }

}
