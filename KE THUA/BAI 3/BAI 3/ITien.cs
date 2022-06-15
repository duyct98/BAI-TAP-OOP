namespace BAI_3
{
    internal interface ITien
    {
        string LoaiTien { get; set; }
        double TiGia { get; set; }

        string info();
    }
}