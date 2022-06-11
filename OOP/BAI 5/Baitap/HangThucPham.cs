using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    internal class hangthucpham
    {
        private DateTime ngaysanxuat = DateTime.Now;
        private string tenhang = "";
        private string mahang = "xxx";
        private long dongia;


        private DateTime ngayhethan;
        public void info()
        {
            string a = null;
            if (ngayhethan < DateTime.Now)
            {
                a="Hang het han";
            }
            
            Console.WriteLine("{0,10}{1,20}{2,20:0,0.000}{3,20}{4,20}{5,15}", mahang, tenhang, dongia, ngaysanxuat.ToString("dd/MM/yyyy"), ngayhethan.ToString("dd/MM/yyyy"), a);
        }
        public hangthucpham(string mahang, string tenhang, long dongia, DateTime ngaysanxuat, DateTime ngayhethan)
        {
            try
            {

                if (mahang == "") { throw new Exception(); }
                else
                {
                    if (DateTime.Compare(ngaysanxuat, DateTime.Now) < 0)
                    {
                        
                        this.ngaysanxuat = ngaysanxuat;
                    }
                    else
                    {
                        this.ngaysanxuat = DateTime.Now;
                    }
                    if (DateTime.Compare(ngaysanxuat, ngayhethan) < 0)
                    {
                        this.ngayhethan = ngayhethan;
                    }
                    else
                    {
                        this.ngayhethan = this.ngaysanxuat;
                    }
                    this.mahang = mahang;
                    this.tenhang = tenhang;
                    this.dongia = dongia;

                }

            }
            catch (Exception)
            {
                Console.WriteLine("loi !!! Ma hang rong");
            }






        }
        ~hangthucpham()
        {

        }
        public void setngayhethang(DateTime ngayhethan)
        {
            if (DateTime.Compare(ngaysanxuat, ngayhethan) < 0)
            {
                this.ngayhethan = ngayhethan;
            }
            else
            {
                this.ngayhethan = this.ngaysanxuat;
            }
        }
        public void setngaysanxuat(DateTime ngaysanxuat)
        {
            if (DateTime.Compare(ngaysanxuat, DateTime.Now) < 0)
            {

                this.ngaysanxuat = ngaysanxuat;
            }
            else
                this.ngayhethan = DateTime.Now;

        }






        public string getmahang()
        {
            return this.mahang;
        }
        public void settenhang(string tenhang)
        {
            if (tenhang == "")
            {
                tenhang = "Ten hang rong !!!";
            }
            else
                this.tenhang = tenhang;
        }
        public string gettenhang()
        {
            return this.tenhang;
        }
        public void setdongia(long dongia)
        {
            if (dongia > 0)
            {
                this.dongia = dongia;
            }
            else
                this.dongia = 0;
        }
        public long getdongia()
        {
            return this.dongia;
        }

    }
}
