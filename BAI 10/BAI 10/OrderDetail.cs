using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_10
{
    internal class OrderDetail:Product
    {
        private int quatity;
        public Product product;

        public int Quatity { get => quatity; set => quatity = value; }
        

       public double calcTotalPrice()
        {
            return this.product.Price * Quatity;
        }
        public OrderDetail(Product data,int soluong)
        {
            this.product = new Product(data.ProductID, data.Description,data.Price);
            Quatity = soluong;
            
        }
        public string infoOrderDetail()
        {
            return string.Format("{0,10}{1,10}{2,10}{3,10}{4,20:0,0}", product.ProductID, product.Description, product.Price,Quatity,calcTotalPrice());
        }
    }
}
