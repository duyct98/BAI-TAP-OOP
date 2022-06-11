using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_12
{
    internal class HocVien
    {
        private string hoTen;
        private string diaChi;
        private string soDienThoai;
        private List<KhoaHoc> khoaHoc = new List<KhoaHoc>();
        
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        
        internal List<KhoaHoc> KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
        public void addKhoaHoc(KhoaHoc data)
        {
            KhoaHoc.Add(data);
        }

        public HocVien(string hoTen, string diaChi, string soDienThoai)
        {
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
           
        }
        public string info()
        {
            return string.Format("{0,-20}{1,10}{2,20}",HoTen,DiaChi,SoDienThoai);

        }

    }
}
