using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_9
{
    internal class CongNhan
    {
        private int maCN;
        private string mHo;
        private string mTen;
        private int mSoSP;

        public int MaCN { get => maCN; set => maCN = value; }
        public string MHo { get => mHo; set => mHo = value; }
        public string MTen { get => mTen; set => mTen = value; }
        public int MSoSP { get => mSoSP; set => mSoSP = value; }
        public CongNhan()
        {
            MaCN = 0;
            MHo = null;
            MTen = null;
            MSoSP = 0;

        }
        public CongNhan(int maCN, string mHo, string mTen, int mSoSP)
        {
            MaCN = maCN;
            MHo = mHo;
            MTen = mTen;
            MSoSP = mSoSP;

        }
        public double luong()
        {
            double donGia = 0;
            if (MSoSP > 0 || MSoSP <= 199)
            {
                donGia = 0.5;
            }
            else if (MSoSP > 199 || MSoSP <= 399)
            {
                donGia = 0.55;
            }
            else if (MSoSP > 399 || MSoSP <= 599)
            {
                donGia = 0.6;
            }
            else if (MSoSP > 599)
            {
                donGia = 0.65;
            }
            if (donGia < 0)
            {
                return 0;
            }
            else
                return MSoSP * donGia;

        }
        public string info()
        {
            return string.Format("{0,10}{1,10}{2,10}{3,10}{4,10}", MaCN, MHo, MTen, MSoSP, luong());
        }
    }
}
