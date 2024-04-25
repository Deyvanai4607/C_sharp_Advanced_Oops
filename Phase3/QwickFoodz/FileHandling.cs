using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static class FileHandling
    {
        //folder and file creation
        public static void Create()
        {
            //folder creation
            if (!Directory.Exists("QwickFoodz"))
            {
                Directory.CreateDirectory("QwickFoodz");
            }
            //file creation
            if (!File.Exists("QwickFoodz/customerInfo.csv"))
            {
                File.Create("QwickFoodz/customerInfo.csv").Close();
            }

            if (!File.Exists("QwickFoodz/foodDetailsInfo.csv"))
            {
                File.Create("QwickFoodz/foodDetailsInfo.csv").Close();
            }

            if (!File.Exists("QwickFoodz/orderDetailsInfo.csv"))
            {
                File.Create("QwickFoodz/orderDetailsInfo.csv").Close();
            }

            if (!File.Exists("QwickFoodz/itemDetailsInfo.csv"))
            {
                File.Create("QwickFoodz/itemDetailsInfo.csv").Close();
            }
        }//folder and file creation end
        //Write csv
        public static void WrteCSV()
        {
            //customerInfo
            string[] customers = new string[Operation.customerDetailsList.Count];
            for (int i = 0; i < Operation.customerDetailsList.Count; i++)
            {
                //WalletBalance	Name	FatherName	Gender	Mobile	DOB	MailID	Location
                customers[i] = Operation.customerDetailsList[i].CustomerID + "," + Operation.customerDetailsList[i].WalletBalance + "," + Operation.customerDetailsList[i].Name + "," + Operation.customerDetailsList[i].FatherName + "," + Operation.customerDetailsList[i].Gender + "," + Operation.customerDetailsList[i].Mobile + "," + Operation.customerDetailsList[i].DOB.ToString("dd/MM/yyyy") + "," + Operation.customerDetailsList[i].MailID + "," + Operation.customerDetailsList[i].Location;
            }
            File.WriteAllLines("QwickFoodz/customerInfo.csv", customers);

            //foodDetailsInfo
            string[] foods = new string[Operation.foodDetailsList.Count];
            for (int i = 0; i < Operation.foodDetailsList.Count; i++)
            {
                //FoodName	PricePerQuantity	QuantityAvailable
                foods[i] = Operation.foodDetailsList[i].FoodID + "," + Operation.foodDetailsList[i].FoodName + "," + Operation.foodDetailsList[i].PricePerQuantity + "," + Operation.foodDetailsList[i].QuantityAvailable;
            }
            File.WriteAllLines("QwickFoodz/foodDetailsInfo.csv", foods);

            //orderDetailsInfo
            string[] orders = new string[Operation.orderDetailsList.Count];
            for (int i = 0; i < Operation.orderDetailsList.Count; i++)
            {
                //CustomerID	TotalPrice	DateOfOrder	OrderStatus
                orders[i] = Operation.orderDetailsList[i].OrderID + "," + Operation.orderDetailsList[i].CustomerID + "," + Operation.orderDetailsList[i].TotalPrice + "," + Operation.orderDetailsList[i].DateOfOrder.ToString("dd/MM/yyyy") + "," + Operation.orderDetailsList[i].OrderStatus;
            }
            File.WriteAllLines("QwickFoodz/orderDetailsInfo.csv", orders);

            //itemDetailsInfo
            string[] items = new string[Operation.itemDetailsList.Count];
            for (int i = 0; i < Operation.itemDetailsList.Count; i++)
            {
                //OrderID	FoodID	PurchaseCount	PriceOfOrder
                items[i] = Operation.itemDetailsList[i].ItemID + "," + Operation.itemDetailsList[i].OrderID + "," + Operation.itemDetailsList[i].FoodID + "," + Operation.itemDetailsList[i].PurchaseCount + "," + Operation.itemDetailsList[i].PriceOfOrder;
            }
            File.WriteAllLines("QwickFoodz/itemDetailsInfo.csv", items);

        }
        //read from Csv

        public static void ReadFromCSV()
        {
            //customerInfo
            string[] customers = File.ReadAllLines("QwickFoodz/customerInfo.csv");
            foreach (string customer in customers)
            {
                string[] cus = customer.Split(",");
                //WalletBalance	Name	FatherName	Gender	Mobile	DOB	MailID	Location
                CustomerDetails customer1 = new CustomerDetails(cus[0], int.Parse(cus[1]), cus[2], cus[3], Enum.Parse<Gender>(cus[4]), cus[5], DateTime.ParseExact(cus[6], "dd/MM/yyyy", null), cus[7], cus[8]);
                Operation.customerDetailsList.Add(customer1);
            }

            //foodDetailsInfo
            string[] foods = File.ReadAllLines("QwickFoodz/foodDetailsInfo.csv");
            foreach (string food in foods)
            {
                //FoodName	PricePerQuantity	QuantityAvailable
                FoodDetails food1 = new FoodDetails(food);
                Operation.foodDetailsList.Add(food1);
            }

            //orderDetailsInfo
            string[] orders = File.ReadAllLines("QwickFoodz/orderDetailsInfo.csv");
            foreach (string order in orders)
            {

                //CustomerID	TotalPrice	DateOfOrder	OrderStatus
                OrderDetails order1 = new OrderDetails(order);
                Operation.orderDetailsList.Add(order1);
            }

            //itemDetailsInfo
            string[] items = File.ReadAllLines("QwickFoodz/itemDetailsInfo.csv");
            foreach (string item in items)
            {

                //OrderID	FoodID	PurchaseCount	PriceOfOrder
                ItemDetails item1 = new ItemDetails(item);
                Operation.itemDetailsList.Add(item1);
            }
        }

    }
}