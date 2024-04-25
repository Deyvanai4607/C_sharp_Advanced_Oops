using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    //enum creation
    public enum OrderStatus{Default,Initiated, Ordered, Cancelled}
    public class OrderDetails 
    {
       
        //static field creation
        private static int s_orderID=4000;
        //properties creation
        //Properties: OrderID {Auto Increment – OID4000}, BookingID, ProductID, PurchaseCount, PriceOfOrder
        public string OrderID { get; }//read only
        public string BookingID { get; set; }
        public string ProductID { get; set; }
        public int PurchaseCount { get; set; }
        public int PriceOfOrder { get; set; }
     
        //Contructor creation
        public OrderDetails(string bookingID, string productID,int purchaseCount,int priceOfOrder){
            s_orderID++;
            OrderID="OID"+s_orderID;
            BookingID=bookingID;
            ProductID=productID;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
            
        }
    }
}