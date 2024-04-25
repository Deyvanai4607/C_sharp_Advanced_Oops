using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class FoodDetails
    {
        //Properties: FoodID, FoodName, PricePerQuantity, QuantityAvailable
        //static feild
        private static int s_foodID = 2000;

        //properties
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public int PricePerQuantity { get; set; }
        public int QuantityAvailable { get; set; }
        //constructor
        //FoodName	PricePerQuantity	QuantityAvailable
        public FoodDetails(string foodName, int pricePerQuantity, int quantityAvailable)
        {
            s_foodID++;
            FoodID = "FID" + s_foodID;
            FoodName = foodName;
            PricePerQuantity = pricePerQuantity;
            QuantityAvailable = quantityAvailable;
        }

        public FoodDetails(string food)
        {
            string[] foo = food.Split(",");

            FoodID = foo[0];
            s_foodID = int.Parse(foo[0].Remove(0, 3));
            FoodName = foo[1];
            PricePerQuantity = int.Parse(foo[2]);
            QuantityAvailable = int.Parse(foo[3]);
        }


    }
}