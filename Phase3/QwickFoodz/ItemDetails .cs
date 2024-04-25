using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class ItemDetails
    {
        //static feild
        private static int s_itemID = 4000;
        //Properties: ItemID – (ITID100), OrderID, FoodID, PurchaseCount, PriceOfOrder
        public string ItemID { get; set; }
        public string OrderID { get; set; }
        public string FoodID { get; set; }
        public int PurchaseCount { get; set; }
        public int PriceOfOrder { get; set; }

        //constructor
        //OrderID	FoodID	PurchaseCount	PriceOfOrder
        public ItemDetails(string orderID, string foodID, int purchaseCount, int priceOfOrder)
        {
            s_itemID++;
            ItemID = "ITID" + s_itemID;
            OrderID = orderID;
            FoodID = foodID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;

        }

        public ItemDetails(string item)
        {
            string[] items = item.Split(",");

            ItemID = items[0];
            s_itemID = int.Parse(items[0].Remove(0, 4));
            OrderID = items[1];
            FoodID = items[2];
            PurchaseCount = int.Parse(items[3]);
            PriceOfOrder = int.Parse(items[4]);

        }
    }
}