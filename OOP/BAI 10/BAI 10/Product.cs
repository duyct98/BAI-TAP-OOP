using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_10
{
    internal class Product
    {
        private string description;
        private string productID;
        private double price;

        public double Price { get => price; set => price = value; }
        public string ProductID { get => productID; set => productID = value; }
        public string Description { get => description; set => description = value; }
        
        public Product()
        {
            price=0.0;
            ProductID = null;
            Description = null;

        }
        public Product(string productID, string description, double price)
        {
            Description = description;
            ProductID = productID;
            Price = price;
            
        }
        internal string infoProduct()
        {
            return string.Format("{0,10}{1,10}{2,10}",Description,ProductID,Price);

        }
    }
}
