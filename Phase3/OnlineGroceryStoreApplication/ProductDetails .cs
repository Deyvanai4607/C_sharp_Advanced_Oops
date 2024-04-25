using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public class ProductDetails 
    {
        //static field 
        private static int s_productID=2000;
        //properties
        //Properties: ProductID {Auto Increment – PID2000}, ProductName, QuantityAvailable, PricePerQuantity
        public string ProductID { get;  }//read only
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public int PricePerQuantity { get; set; }
       
        //Constructor
        public ProductDetails(string productName,int quantityAvailable,int pricePerQuantity){
            s_productID++;
            ProductID="PID"+s_productID;
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricePerQuantity;
           
        }
        public void ShowProductDetails(string productID){
            System.Console.WriteLine($"|{"ProductID",-15}|{"ProductName",-15}|{"QuantityAvailable",-15}|{"PricePerQuantity",-15}|");
            if(productID.Equals(ProductID)){    
                System.Console.WriteLine($"|{ProductID,-15}|{ProductName,-15}|{QuantityAvailable,-15}|{PricePerQuantity,-15}|");            
            }
        }
    }
}