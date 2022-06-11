using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_12
{
    internal class Menu
    {
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("============== MENU ==============");
            Console.WriteLine("1. Quan Ly Hoc Vien");
            Console.WriteLine("2. Quan Ly Khoa Hoc");
            Console.WriteLine("0. Exit");
        }
        public static void menuHV()
        {
            Console.WriteLine("========== MENU HOC VIEN==========");
            Console.WriteLine("1. Them hoc vien");
            Console.WriteLine("2. Xoa hoc vien");
            Console.WriteLine("3. Xem thong tin hoc vien");
            Console.WriteLine("4. Dang ky khoa hoc cho hoc vien");
            Console.WriteLine("5. Xem thong tin cac hoc vien");
            Console.WriteLine("0. Back");
        }
        public static void menuKH()
        {
            Console.WriteLine("========== MENU KHOA HOC==========");
            Console.WriteLine("1. Them khoa hoc");
            Console.WriteLine("2. Dang ky khoa hoc cho hoc vien");
            Console.WriteLine("3. Xem thong tin khoa hoc");
            Console.WriteLine("4. Xem thong tin Hoc Vien");
            Console.WriteLine("5. Xem thong tin khoa hoc chua ket thuc");
            Console.WriteLine("6. Xem thong tin khoa hoc chua bat dau");
            Console.WriteLine("0. Back");
        }

        private static int luaChon;

        public static int LuaChon { get => luaChon; set => luaChon = value; }

        public static void LC()
        {
            Console.WriteLine("-------------------------------------");
            Console.Write("Nhap lua chon :");
            LuaChon = Convert.ToInt32(Console.ReadLine());
           

        }
        private static DateTime nhapNgayThang()
        {
            Console.Write("Nhap ngay: ");
            int ngay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap thang: ");
            int thang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int nam = Convert.ToInt32(Console.ReadLine());
            return new DateTime(nam, thang, ngay);

        }
        public static void run()
        {
            switch (LuaChon)
            {
                case 1:
                    Console.Clear();
                    menuHV();
                    LC();
                    switch (LuaChon)
                    {
                        case 1:
                            Console.WriteLine("Nhap ten:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Nhap dia chi:");
                            string diaChi = Console.ReadLine();
                            Console.WriteLine("Nhap sdt:");
                            string sdt = Console.ReadLine();
                            ListHV.listHV.Add(new HocVien(name, diaChi, sdt));
                            Console.ReadKey();
                            break;
                        case 2:
                            string sdtXoa = Console.ReadLine();
                            for(int i = 0; i < ListHV.listHV.Count;i++)
                            {
                                if (string.Compare(ListHV.listHV[i].SoDienThoai,sdtXoa)==0)
                                {
                                    ListHV.listHV.RemoveAt(i);
                                }
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Write("Nhap sdt hoc vien: ");
                            string sdtDK = Console.ReadLine();
                            for (int i=0; i < ListHV.listHV.Count; i++)
                            {
                                if (string.Compare(ListHV.listHV[i].SoDienThoai, sdtDK) == 0)
                                {   

                                    Console.WriteLine("----------THONG TIN HOC VIEN-----------");
                                    Console.WriteLine(ListHV.listHV[i].info());
                                    Console.WriteLine("----------KHOA HOC-----------");
                                    Console.WriteLine("{0,-20}{1,10}{2,20}{3,20}", "Ten KH", "Ngay mo", "Ngay dong", "Thoi gian(ngay)");
                                    Console.WriteLine("-------------------------------------");
                                    for (int j = 0; j < ListHV.listHV[i].KhoaHoc.Count; j++)
                                    {                                        
                                        Console.WriteLine(ListHV.listHV[i].KhoaHoc[j].info());
                                    }
                                        
                                }

                            }
                            Console.ReadKey();
                            break;
                        case 4:

                            ListKH.DSKH();
                            Console.Write("Nhap sdt hoc vien: ");
                            sdtDK = Console.ReadLine();
                            Console.Write("Nhap ten khoa hoc: ");
                            string kHDK = Console.ReadLine();
                            for (int i = 0; i < ListKH.listKH.Count; i++)
                            {
                                if (string.Compare(kHDK,ListKH.listKH[i].TenKH)==0)
                                {
                                    
                                    for(int j = 0; j < ListHV.listHV.Count; j++)
                                    {
                                        if (string.Compare(ListHV.listHV[j].SoDienThoai,sdtDK)==0)
                                        {
                                            ListKH.listKH[i].add(ListHV.listHV[j]);
                                            ListHV.listHV[j].KhoaHoc.Add(ListKH.listKH[i]);
                                        }                                   
                                        
                                    }
                                    
                                }
                            }
                            Console.ReadKey();
                            break;
                        case 5:
                            ListHV.DSHV();
                            Console.ReadKey();
                            break;
                        case 0:
                            break;
                    }
                    break;
                case 2:

                    Console.Clear();
                    menuKH();
                    LC();
                    switch (luaChon)
                    {
                        case 1:
                            Console.WriteLine("Nhap ten KH:");
                            string tenKH = Console.ReadLine();
                            Console.WriteLine("Nhap ngay mo.");
                            DateTime ngayMo = nhapNgayThang();
                            Console.WriteLine("Nhap ngay dong. ");
                            DateTime ngayDong = nhapNgayThang();

                            break;
                        case 2:
                            ListKH.DSKH();
                            Console.Write("Nhap sdt hoc vien: ");
                            string sdtDK = Console.ReadLine();
                            Console.Write("Nhap ten khoa hoc: ");
                            string kHDK = Console.ReadLine();
                            for (int i = 0; i < ListKH.listKH.Count; i++)
                            {
                                if (kHDK == ListKH.listKH[i].TenKH)
                                {
                                    
                                    for (int j = 0; j < ListHV.listHV.Count; j++)
                                    {
                                        if (string.Compare(ListHV.listHV[j].SoDienThoai,sdtDK)==0)
                                        {
                                            ListKH.listKH[i].add(ListHV.listHV[j]);
                                        }


                                    }

                                }
                            }
                            Console.ReadKey();
                            break;

                        case 3:
                            ListKH.DSKH();
                            break;
                        case 4:
                            ListKH.DSKH();
                            Console.Write("Nhap ten khoa hoc: ");
                            kHDK = Console.ReadLine();
                            ListKH.DSHVDK(kHDK);
                            break;
                        case 5:
                            Console.WriteLine("----------KHOA HOC CHUA KET THUC-----------");
                            Console.WriteLine("{0,-20}{1,10}{2,20}{3,20}", "Ten KH", "Ngay mo", "Ngay dong", "Thoi gian(ngay)");
                            Console.WriteLine("-------------------------------------");
                            for (int i=0; i < ListKH.listKH.Count; i++)
                            {                                
                                if (DateTime.Compare(ListKH.listKH[i].NgayDong, DateTime.Now) < 0)
                                {
                                    
                                }
                            }
                            break;
                        case 6:
                            Console.WriteLine("----------KHOA HOC CHUA BAT DAU-----------");
                            Console.WriteLine("{0,-20}{1,10}{2,20}{3,20}", "Ten KH", "Ngay mo", "Ngay dong", "Thoi gian(ngay)");
                            Console.WriteLine("-------------------------------------");
                            for (int i = 0; i < ListKH.listKH.Count; i++)
                            {
                                if (DateTime.Compare(ListKH.listKH[i].NgayMo, DateTime.Now) > 0)
                                {
                                    Console.WriteLine(ListKH.listKH[i].info());
                                }
                            }
                            break;
                        case 0:
                            break;
                    }

                    Console.ReadKey();
                    break;
            }
        }

    }
}
