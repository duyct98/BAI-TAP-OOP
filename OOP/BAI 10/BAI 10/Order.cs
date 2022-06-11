using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_10
{
    internal class Order
    {
        private int orderID = 0;
        private DateTime orderDate;
        private List <OrderDetail> lineItem = new List<OrderDetail>() ;
        

        public int OrderID { get => orderID;}
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public List<OrderDetail> LineItem { get => lineItem;}

        public Order(int orderID, DateTime OrderDate)
        {
            this.orderID = orderID;
            this.OrderDate = OrderDate;
        }
        
        public void addLineItem(Product product,int soLuong)
        {
            LineItem.Add(new OrderDetail(product, soLuong));
        }
        public double calcTotalCharge()
        {
            double tongBill=0;
            for(int i=0; i < LineItem.Count; i++)
            {
                tongBill= tongBill + LineItem[i].calcTotalPrice();
            }
            return tongBill;
        }
        public void infoOrder()
        {

                     
            Console.WriteLine("Ma HD: {0}\nNgay lap hoa don: {1}",this.OrderID, this.OrderDate.ToString("dd/MM/yyyy"));
            Console.ResetColor();
            
            
            Console.WriteLine("{0,-10}|  {1,-10}|  {2,-20}|  {3,10:0,0}  |{4,10}  |{5,20:0,0 VND}", "STT", "Ma SP", "Mo ta", "Don gia", "So luong", "Thanh tien");
            
            for (int i=0; i < LineItem.Count; i++)                
            {
                Console.WriteLine("{0,-10}|  {1,-10}|  {2,-20}|  {3,10:0,0}  |{4,10}  |{5,20:0,0 VND}", i+1, LineItem[i].product.ProductID, LineItem[i].product.Description, LineItem[i].product.Price, LineItem[i].Quatity, LineItem[i].calcTotalPrice());                
            }
            Console.WriteLine("Tong tien thanh toan: {0:0,0 VND}", calcTotalCharge());
        }
    }
}
