using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_12
{
    internal class KhoaHoc
    {
        private string tenKH;
        private DateTime ngayMo;
        private DateTime ngayDong;
        private TimeSpan thoiGianHoc;
        protected int count = 0;
        public List<HocVien> listHVDK = new List< HocVien >();
        public string TenKH { get => tenKH; set => tenKH = value; }
        public DateTime NgayMo { get => ngayMo; set => ngayMo = value; }
        public DateTime NgayDong { get => ngayDong; set => ngayDong = value; }
        public TimeSpan ThoiGianHoc { get => thoiGianHoc; set => thoiGianHoc = value; }

        
        protected int getCount { get => count; set => count = value; }

        public KhoaHoc(string tenKH, DateTime ngayMo, DateTime ngayDong)
        {
            TenKH = tenKH;
            NgayMo = ngayMo;
            NgayDong = ngayDong;
            ThoiGianHoc = ngayDong - ngayMo;

            
        }
        
        public void add(HocVien data)
        {
            if (listHVDK.Count == 20)
            {
                Console.WriteLine("add false !!!");
            }
            else
            {   

                listHVDK.Add(data);
                getCount++;
                Console.WriteLine("add successful !!!");
            }
            
        }
        public int kiemTraHV(HocVien sdt)
        {
            for(int i = 0; i < listHVDK.Count; i++)
            {
                if (listHVDK[i].SoDienThoai == sdt.SoDienThoai)
                {
                    return 1;
                }
                
            }
            return 0;
        }
        public string info()
        {
            return String.Format("{0,-20}{1,10}{2,20}{3,20}", TenKH, NgayMo.ToString("dd/MM/yyyy"), NgayDong.ToString("dd/MM/yyyy"), ThoiGianHoc.Days);
        }
    }
}
