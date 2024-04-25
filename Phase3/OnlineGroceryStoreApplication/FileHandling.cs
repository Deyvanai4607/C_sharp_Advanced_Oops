using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public static class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("OnlineGroceryStoreApplication")){
                Directory.CreateDirectory("OnlineGroceryStoreApplication");
            }   
            if(!File.Exists("OnlineGroceryStoreApplication/PersonaInfo.csv")){
                File.Create("OnlineGroceryStoreApplication/PersonaInfo.csv");
            } 
            if(!File.Exists("OnlineGroceryStoreApplication/ProductInfo.csv")){
                File.Create("OnlineGroceryStoreApplication/ProductInfo.csv");
            }    
            if(!File.Exists("OnlineGroceryStoreApplication/BookingInfo.csv")){
                File.Create("OnlineGroceryStoreApplication/BookingInfo.csv");
            }    
            if(!File.Exists("OnlineGroceryStoreApplication/CustomerRegistrationInfo.csv")){
                File.Create("OnlineGroceryStoreApplication/CustomerRegistrationInfo.csv");
            }  
            //OrderDetails  
            if(!File.Exists("OnlineGroceryStoreApplication/OrderDetailsInfo.csv")){
                File.Create("OnlineGroceryStoreApplication/OrderDetailsInfo.csv");
            }
        }
    }
}