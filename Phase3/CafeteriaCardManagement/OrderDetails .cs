using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    //enum creation
    public enum OrderStatus{Default,Initiated, Ordered, Cancelled}
    public class OrderDetails 
    {
        /*•	OrderID (Auto – OID1001)
•	UserID
•	OrderDate
•	TotalPrice
•	OrderStatus – (Default, Initiated, Ordered, Cancelled)
*/
        //static field creation
        private static int s_orderID=1000;
        //properties creation
        public string OrderID { get; }//read only
        public string UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }        
        //Contructor creation
        public OrderDetails(string userID,DateTime orderDate,int totalPrice,OrderStatus orderStatus){
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            OrderDate=orderDate;
            TotalPrice=totalPrice;
            OrderStatus=orderStatus;
        }
    }
}