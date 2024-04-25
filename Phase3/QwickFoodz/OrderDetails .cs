using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public enum OrderStatus { Default, Initiated, Ordered, Cancelled }
    public class OrderDetails
    {
        //static feild
        private static int s_orderID = 3000;
        //Properties: OrderID, CustomerID, TotalPrice, DateOfOrder, OrderStatus – {Default, Initiated, Ordered, Cancelled}.
        public string OrderID { get; set; }
        public string CustomerID { get; set; }
        public int TotalPrice { get; set; }
        public DateTime DateOfOrder { get; set; }
        public OrderStatus OrderStatus { get; set; }
        //constructor
        //CustomerID	TotalPrice	DateOfOrder	OrderStatus
        public OrderDetails(string customerID, int totalPrice, DateTime dateOfOrder, OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID = "OID" + s_orderID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfOrder = dateOfOrder;
            OrderStatus = orderStatus;
        }

        public OrderDetails(string order)
        {
            string[] ode = order.Split(",");

            OrderID = ode[0];
            s_orderID = int.Parse(ode[0].Remove(0, 3));
            CustomerID = ode[1];
            TotalPrice = int.Parse(ode[2]);
            DateOfOrder = DateTime.ParseExact(ode[3], "dd/MM/yyyy", null);
            OrderStatus = Enum.Parse<OrderStatus>(ode[4]);
        }

    }
}