using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3
{
    internal interface IGiaoDich

    {
        
        DateTime NgayGiaoDich { get; set; }
        double DonGia { get; set; }
        int SoLuong { get; set; }
        double ThanhTien { get; set; }
        string MaGiaoDich { get; set; }

        string info();
    }
}
