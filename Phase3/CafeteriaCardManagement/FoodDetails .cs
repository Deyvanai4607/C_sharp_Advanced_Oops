using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public class FoodDetails 
    {
        /*•	FoodID (Auto - FID101)
•	FoodName
•	FoodPrice
•	AvailableQuantity
*/
        //static field 
        private static int s_foodID=100;
        //properties
        public string FoodID { get;  }//read only
        public string FoodName { get; set; }
        public int FoodPrice { get; set; }
        public int AvailableQuantity { get; set; }
        
        //Constructor
        public FoodDetails(string foodName,int foodPrice,int availableQuantity){
            s_foodID++;
            FoodID="FID"+s_foodID;
            FoodName=foodName;
            FoodPrice=foodPrice;
            AvailableQuantity=availableQuantity;
             
        }
    }
}