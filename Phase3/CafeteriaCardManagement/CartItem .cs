using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public class CartItem 
    {
         
        //static field creation
        private static int s_itemID=100;
        //properties creation
        public string ItemID { get; }//read only
        public string OrderID { get; set; }
        public string FoodID { get; set; }
        public int OrderPrice { get; set; }
        public int OrderQuantity { get; set; }
               
        //Contructor creation
        public CartItem(string orderID,string foodID,int orderPrice, int orderQuantity ){
            s_itemID++;
            ItemID="ITID"+s_itemID;
            OrderID=orderID;
            FoodID=foodID;
            OrderPrice=orderPrice;
            OrderQuantity=orderQuantity;
         
        }

    }
}