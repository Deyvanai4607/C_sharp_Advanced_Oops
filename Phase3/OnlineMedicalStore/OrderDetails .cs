using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public enum OrderStatus{Purchased, Cancelled}
    public class OrderDetails 
    {
        /*Properties:
        a.	OrderID (Auto increment - OID2001)
        b.	UserID
        c.	MedicineID
        d.	MedicineCount
        e.	TotalPrice
        f.	OrderDate
        g.	OrderStatus {Enum – Purchased, Cancelled}
        */
        //static feild
        private static int s_orderID=2000;
        //properties
        public string OrderID { get; set; }
        public string UserID { get; set; }
        public string MedicineID { get; set; }
        public int MedicineCount { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        //constructor
        public OrderDetails(string userID,string medicineID,int medicineCount,int totalPrice,DateTime orderDate,OrderStatus orderStatus){
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            MedicineID=medicineID;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            OrderStatus=orderStatus;
        }

        public OrderDetails(string order){
            string[] ord=order.Split(",");
            
            OrderID=ord[0];
            s_orderID=int.Parse(ord[0].Remove(0,3));
            UserID=ord[1];
            MedicineID=ord[2];
            MedicineCount=int.Parse(ord[3]);
            TotalPrice=int.Parse(ord[4]);
            OrderDate=DateTime.ParseExact(ord[5],"dd/MM/yyyy",null);
            OrderStatus=Enum.Parse<OrderStatus>(ord[6]);
        }
        
        
        
        
        
        
    }
}