using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static class Operation
    {
        public static CustomerDetails currentCustomer;
        //lists
        public static CustomList<CustomerDetails> customerDetailsList = new CustomList<CustomerDetails>();
        public static CustomList<FoodDetails> foodDetailsList = new CustomList<FoodDetails>();
        public static CustomList<OrderDetails> orderDetailsList = new CustomList<OrderDetails>();
        public static CustomList<ItemDetails> itemDetailsList = new CustomList<ItemDetails>();

        //defaul values 
        public static void DefaultValues()
        {
            //customer detail
            CustomerDetails customer1 = new CustomerDetails(10000, "Ravi", "Ettapparajan", Gender.Male, "974774646", new DateTime(1999, 11, 11), "ravi@gmail.com", "Chennai");
            CustomerDetails customer2 = new CustomerDetails(15000, "Baskaran", "Sethurajan", Gender.Male, "847575775", new DateTime(1999, 11, 11), "baskaran@gmail.com", "Chennai");
            customerDetailsList.Add(customer1);
            customerDetailsList.Add(customer2);

            //food details  
            FoodDetails food1 = new FoodDetails("Chicken Briyani 1Kg", 100, 12);
            FoodDetails food2 = new FoodDetails("Mutton Briyani 1Kg", 150, 10);
            FoodDetails food3 = new FoodDetails("Veg Full Meals", 80, 30);
            FoodDetails food4 = new FoodDetails("Noodles", 100, 40);
            FoodDetails food5 = new FoodDetails("Dosa", 40, 40);
            FoodDetails food6 = new FoodDetails("Idly (2 pieces)", 20, 50);
            FoodDetails food7 = new FoodDetails("Pongal", 40, 20);
            FoodDetails food8 = new FoodDetails("Vegetable Briyani", 80, 15);
            FoodDetails food9 = new FoodDetails("Lemon Rice", 50, 30);
            FoodDetails food10 = new FoodDetails("Veg Pulav", 120, 30);
            FoodDetails food11 = new FoodDetails("Chicken 65 (200 Grams)", 75, 30);
            foodDetailsList.Add(food1);
            foodDetailsList.Add(food2);
            foodDetailsList.Add(food3);
            foodDetailsList.Add(food4);
            foodDetailsList.Add(food5);
            foodDetailsList.Add(food6);
            foodDetailsList.Add(food7);
            foodDetailsList.Add(food8);
            foodDetailsList.Add(food9);
            foodDetailsList.Add(food10);
            foodDetailsList.Add(food11);

            //OrderDetails
            OrderDetails order1 = new OrderDetails("CID1001", 580, new DateTime(2022, 11, 26), OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails("CID1002", 870, new DateTime(2022, 11, 26), OrderStatus.Ordered);
            OrderDetails order3 = new OrderDetails("CID1001", 820, new DateTime(2022, 11, 26), OrderStatus.Cancelled);
            orderDetailsList.Add(order1);
            orderDetailsList.Add(order2);
            orderDetailsList.Add(order3);

            //ItemDetails
            ItemDetails item1 = new ItemDetails("OID3001", "FID2001", 2, 200);
            ItemDetails item2 = new ItemDetails("OID3001", "FID2002", 2, 300);
            ItemDetails item3 = new ItemDetails("OID3001", "FID2003", 1, 80);
            ItemDetails item4 = new ItemDetails("OID3002", "FID2001", 1, 100);
            ItemDetails item5 = new ItemDetails("OID3002", "FID2002", 4, 600);
            ItemDetails item6 = new ItemDetails("OID3002", "FID2010", 1, 120);
            ItemDetails item7 = new ItemDetails("OID3002", "FID2009", 1, 50);
            ItemDetails item8 = new ItemDetails("OID3003", "FID2002", 2, 300);
            ItemDetails item9 = new ItemDetails("OID3003", "FID2008", 4, 320);
            ItemDetails item10 = new ItemDetails("OID3003", "FID2001", 2, 200);
            itemDetailsList.Add(item1);
            itemDetailsList.Add(item2);
            itemDetailsList.Add(item3);
            itemDetailsList.Add(item4);
            itemDetailsList.Add(item5);
            itemDetailsList.Add(item6);
            itemDetailsList.Add(item7);
            itemDetailsList.Add(item8);
            itemDetailsList.Add(item9);
            itemDetailsList.Add(item10);


        }//default end
        //Main menu
        public static void MainMenu()
        {
            /*1.	Customer Registration
            2.	Customer Login
            3.	Exit
            */
            string mainChoice = "yes";
            do
            {
                System.Console.WriteLine("Select option\n1.Customer Registration\n2.Customer Login\n3.Exit");
                int mainOption = int.Parse(Console.ReadLine());
                switch (mainOption)
                {
                    case 1:
                        {
                            System.Console.WriteLine("****************************Customer Registration*******************************");
                            CustomerRegistration();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("****************************Customer Login*******************************");
                            CustomerLogin();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("****************************Exit Main menu*******************************");
                            mainChoice = "no";
                            break;
                        }
                }
            } while (mainChoice == "yes");
        }//main menu end
        //CustomerRegistration
        public static void CustomerRegistration()
        {
            /*i.	Name,
            ii.	FatherName, 
            iii.	Gender- {Select, Male, Female, Transgender}, 
            iv.	Mobile, 
            v.	DOB, 
            vi.	MailID, 
            vii.	Location
           
            */
            //get customer details
            System.Console.Write("Enter customer Name : ");
            string name = Console.ReadLine();
            System.Console.Write("Enter customer FatherName : ");
            string fatherName = Console.ReadLine();
            System.Console.Write("Enter customer Gender : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            System.Console.Write("Enter customer Mobile number : ");
            string mobile = Console.ReadLine();
            System.Console.Write("Enter customer DOB : ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            System.Console.Write("Enter customer MailID : ");
            string mailID = Console.ReadLine();
            System.Console.Write("Enter customer Location : ");
            string location = Console.ReadLine();
            System.Console.Write("Enter Customer balance : ");
            int balance = int.Parse(Console.ReadLine());
            //object creation
            CustomerDetails customer = new CustomerDetails(balance, name, fatherName, gender, mobile, dob, mailID, location);
            //add to list
            customerDetailsList.Add(customer);
            //display
            System.Console.WriteLine($"Customer registration successful Your Customer ID: {customer.CustomerID}");
        }//CustomerRegistration end

        //CustomerLogin
        public static void CustomerLogin()
        {
            System.Console.Write("Enter CustomerID : ");
            string customerId = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (CustomerDetails customer in customerDetailsList)
            {
                if (customerId.Equals(customer.CustomerID))
                {
                    currentCustomer = customer;
                    SubMenu();
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                System.Console.WriteLine("Invalid user ID");
            }
        }//CustomerLogin end
        //SubMenu
        public static void SubMenu()
        {
            /*
            i.	Show Profile
            ii.	Order Food
            iii.	Cancel Order
            iv.	Modify Order 
            v.	Order History
            vi.	Recharge Wallet
            vii.	Show Wallet Balance
            viii.	Exit
            */
            string subChoice = "yes";
            do
            {
                System.Console.WriteLine("Select sub option\n1.Show Profile\n2.Order Food\n3.Cancel Order\n4.Modify Order\n5.Order History\n6.Recharge Wallet\n7.Show Wallet Balance\n8.Exit");
                int subOption = int.Parse(Console.ReadLine());
                switch (subOption)
                {
                    case 1:
                        {
                            System.Console.WriteLine("********************Show Profile********************");
                            ShowProfile();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("********************Order Food********************");
                            OrderFood();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("********************Cancel Order*******************");
                            CancelOrder();
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("********************Modify Order********************");
                            ModifyOrder();
                            break;
                        }
                    case 5:
                        {
                            System.Console.WriteLine("********************Order History********************");
                            OrderHistory();
                            break;
                        }
                    case 6:
                        {
                            System.Console.WriteLine("********************Recharge Wallet*******************");
                            RechargeWallet();
                            break;
                        }
                    case 7:
                        {
                            System.Console.WriteLine("********************Show Wallet Balance********************");
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            System.Console.WriteLine("********************Exit sub menu********************");
                            subChoice = "no";
                            break;
                        }
                }
            } while (subChoice == "yes");
        }//SubMenu end
        //ShowProfile
        public static void ShowProfile()
        {
            ////WalletBalance	Name	FatherName	Gender	Mobile	DOB	MailID	Location
            System.Console.WriteLine($"CusomerID : {currentCustomer.CustomerID}");
            System.Console.WriteLine($"Name : {currentCustomer.Name}");
            System.Console.WriteLine($"FatherName : {currentCustomer.FatherName}");
            System.Console.WriteLine($"Gender : {currentCustomer.Gender}");
            System.Console.WriteLine($"Mobile number : {currentCustomer.Mobile}");
            System.Console.WriteLine($"DOB : {currentCustomer.DOB}");
            System.Console.WriteLine($"MailID : {currentCustomer.MailID}");
            System.Console.WriteLine($"Location : {currentCustomer.Location}");
            System.Console.WriteLine($"WalletBalance : {currentCustomer.WalletBalance}");

        }//ShowProfile end
        //OrderFood
        public static void OrderFood()
        {
            //order detail object
            //CustomerID	TotalPrice	DateOfOrder	OrderStatus
            OrderDetails order = new OrderDetails(currentCustomer.CustomerID, 0, DateTime.Now, OrderStatus.Initiated);
            //local item list
            CustomList<ItemDetails> localItemList = new CustomList<ItemDetails>();
            //list the food item
            string itemChoice = "no";
            do
            {
                System.Console.WriteLine($"|{"FoodID",-15}|{"FoodName",-23}|{"PricePerQuantity",-15}|{"QuantityAvailable",-15}|");
                foreach (FoodDetails food in foodDetailsList)
                {
                    System.Console.WriteLine($"|{food.FoodID,-15}|{food.FoodName,-23}|{food.PricePerQuantity,-15}|{food.QuantityAvailable,-15}|");
                }
                System.Console.Write("Enter the FoodID : ");
                string foodId = Console.ReadLine().ToUpper();
                System.Console.Write("Enter the quantity of the Food you want : ");
                int quantity = int.Parse(Console.ReadLine());
                foreach (FoodDetails food in foodDetailsList)
                {
                    if (foodId.Equals(food.FoodID) && quantity <= food.QuantityAvailable)
                    {
                        //item details object
                        //OrderID	FoodID	PurchaseCount	PriceOfOrder
                        ItemDetails item = new ItemDetails(order.OrderID, food.FoodID, quantity, quantity * food.PricePerQuantity);
                        food.QuantityAvailable = food.QuantityAvailable - quantity;
                        order.TotalPrice = order.TotalPrice + quantity * food.PricePerQuantity;
                        // add local item list
                        localItemList.Add(item);

                    }
                }
                bool flag1 = true;
                bool flag2 = true;
                foreach (FoodDetails food in foodDetailsList)
                {
                    if (foodId.Equals(food.FoodID))
                    {
                        flag1 = false;
                        break;
                    }
                }
                foreach (FoodDetails food in foodDetailsList)
                {
                    if (foodId.Equals(food.FoodID) && quantity <= food.QuantityAvailable)
                    {
                        flag1 = false;
                        break;
                    }
                }
                if (flag1)
                {
                    System.Console.WriteLine("FoodID Invalid ");
                }
                else
                {
                    if (flag2)
                    {
                        System.Console.WriteLine("FoodQuantity unavailable ");
                    }
                }
                System.Console.WriteLine("Do you want to order more : (yes/no)");
                itemChoice = Console.ReadLine();


            } while (itemChoice == "yes");
            if (itemChoice == "no")
            {
                System.Console.WriteLine("Do you want to confirm purchase : (yes/no)");
                string puchaseChoise = Console.ReadLine();
                if (puchaseChoise == "yes")
                {
                    if (order.TotalPrice <= currentCustomer.WalletBalance)
                    {
                        order.OrderStatus = OrderStatus.Ordered;
                        orderDetailsList.Add(order);
                        currentCustomer.DeductBalance(order.TotalPrice);
                        itemDetailsList.AddRange(localItemList);
                    }
                    else
                    {
                        System.Console.WriteLine("Your wallet has insufficient balance and whether wish to recharge /not.(yes/no)");
                        string rechargeChoice = Console.ReadLine();
                        if (rechargeChoice == "yes")
                        {
                            System.Console.WriteLine("Enter the amount to be recharge :");
                            int amount = int.Parse(Console.ReadLine());
                            currentCustomer.WalletRecharge(amount);
                            System.Console.WriteLine($"Current balance is {currentCustomer.WalletBalance} ");
                        }
                        else
                        {
                            foreach (FoodDetails food in foodDetailsList)
                            {
                                foreach (ItemDetails item in localItemList)
                                {
                                    if (food.FoodID.Equals(item.FoodID))
                                    {
                                        food.QuantityAvailable = food.QuantityAvailable + item.PurchaseCount;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    foreach (FoodDetails food in foodDetailsList)
                    {
                        foreach (ItemDetails item in localItemList)
                        {
                            if (food.FoodID.Equals(item.FoodID))
                            {
                                food.QuantityAvailable = food.QuantityAvailable + item.PurchaseCount;
                            }
                        }
                    }
                }
            }

        }//OrderFood end
        //CancelOrder
        public static void CancelOrder()
        {
            ////CustomerID	TotalPrice	DateOfOrder	OrderStatus
            System.Console.WriteLine($"|{"OrderID",-15}|{"CustomerID",-15}|{"TotalPrice",-15}|{"DateOfOrder",-15}|{"OrderStatus",-15}|");
            foreach (OrderDetails order in orderDetailsList)
            {
                if (currentCustomer.CustomerID.Equals(order.CustomerID) && order.OrderStatus == OrderStatus.Ordered)
                {
                    System.Console.WriteLine($"|{order.OrderID,-15}|{order.CustomerID,-15}|{order.TotalPrice,-15}|{order.DateOfOrder,-15}|{order.OrderStatus,-15}|");
                }
            }
            System.Console.Write("To pick an order to be cancelled by OrderID : ");
            string orderId = Console.ReadLine().ToUpper();
            foreach (OrderDetails order in orderDetailsList)
            {
                if (orderId.Equals(order.OrderID))
                {
                    order.OrderStatus = OrderStatus.Cancelled;
                    currentCustomer.WalletRecharge(order.TotalPrice);

                    foreach (ItemDetails item in itemDetailsList)
                    {

                        if (order.OrderID.Equals(item.OrderID))
                        {
                            foreach (FoodDetails food in foodDetailsList)
                            {
                                if (item.FoodID.Equals(food.FoodID))
                                {
                                    food.QuantityAvailable = food.QuantityAvailable + item.PurchaseCount;
                                }
                            }

                        }


                    }

                }
            }


        }//CancelOrder end
        //ModifyOrder
        public static void ModifyOrder()
        {
            System.Console.WriteLine($"|{"OrderID",-15}|{"CustomerID",-15}|{"TotalPrice",-15}|{"DateOfOrder",-15}|{"OrderStatus",-15}|");
            foreach (OrderDetails order in orderDetailsList)
            {
                if (currentCustomer.CustomerID.Equals(order.CustomerID) && order.OrderStatus == OrderStatus.Ordered)
                {
                    System.Console.WriteLine($"|{order.OrderID,-15}|{order.CustomerID,-15}|{order.TotalPrice,-15}|{order.DateOfOrder,-15}|{order.OrderStatus,-15}|");
                }
            }
            System.Console.Write("To pick an order to be modified by OrderID : ");
            string modifyId = Console.ReadLine().ToUpper();
            foreach (OrderDetails order in orderDetailsList)
            {
                if (currentCustomer.CustomerID.Equals(order.CustomerID) && order.OrderStatus == OrderStatus.Ordered)
                {
                    if (modifyId.Equals(order.OrderID))
                    {
                        System.Console.WriteLine($"|{"ItemID",-15}|{"OrderID",-15}|{"FoodID",-15}|{"PurchaseCount",-15}|{"PriceOfOrder",-15}|");
                        foreach (ItemDetails item in itemDetailsList)
                        {
                            if (modifyId.Equals(item.OrderID))
                            {
                                System.Console.WriteLine($"|{item.ItemID,-15}|{item.OrderID,-15}|{item.FoodID,-15}|{item.PurchaseCount,-15}|{item.PriceOfOrder,-15}|");
                            }
                        }
                        System.Console.Write("Pick ItemID which you want to be modify :");
                        string modifyItem = Console.ReadLine().ToUpper();
                        foreach (ItemDetails item in itemDetailsList)
                        {
                            if (modifyItem.Equals(item.ItemID))
                            {
                                System.Console.Write("Enter new item quantity : ");
                                int newQuantity = int.Parse(Console.ReadLine());
                                int newPrice = 0;
                                foreach (FoodDetails food in foodDetailsList)
                                {
                                    if (food.FoodID.Equals(item.FoodID))
                                    {
                                        newPrice = newQuantity * food.PricePerQuantity;
                                    }
                                }
                                if (newQuantity > item.PurchaseCount)
                                {
                                    if (currentCustomer.WalletBalance >= newPrice)
                                    {
                                        currentCustomer.DeductBalance(newPrice - item.PriceOfOrder);
                                        item.PriceOfOrder = newPrice;
                                        item.PurchaseCount = newQuantity;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Go to recharge ");
                                    }
                                }
                                else
                                {
                                    currentCustomer.WalletRecharge(item.PriceOfOrder - newPrice);
                                    item.PriceOfOrder = newPrice;
                                    item.PurchaseCount = newQuantity;
                                }

                            }
                        }

                    }
                    int total = 0;
                    foreach (ItemDetails item in itemDetailsList)
                    {

                        if (order.OrderID.Equals(item.OrderID))
                        {
                            total = total + item.PriceOfOrder;
                        }
                    }
                    order.TotalPrice = total;
                    System.Console.WriteLine($"{order.OrderID} modified successfully");
                }

            }
        }//ModifyOrder end
        //OrderHistory
        public static void OrderHistory()
        {
            System.Console.WriteLine($"|{"OrderID",-15}|{"CustomerID",-15}|{"TotalPrice",-15}|{"DateOfOrder",-15}|{"OrderStatus",-15}|");
            foreach (OrderDetails order in orderDetailsList)
            {
                if (currentCustomer.CustomerID.Equals(order.CustomerID))
                {
                    System.Console.WriteLine($"|{order.OrderID,-15}|{order.CustomerID,-15}|{order.TotalPrice,-15}|{order.DateOfOrder.ToString("dd/MM/yyyy"),-15}|{order.OrderStatus,-15}|");
                }
            }
        }//OrderHistory end
        //RechargeWallet
        public static void RechargeWallet()
        {
            System.Console.Write("Enter the amount to be recharged : ");
            int rechargeAmount = int.Parse(Console.ReadLine());
            currentCustomer.WalletRecharge(rechargeAmount);
        }//RechargeWallet end
        //ShowWalletBalance
        public static void ShowWalletBalance()
        {
            System.Console.WriteLine($"{currentCustomer.CustomerID} is WalletBalance : {currentCustomer.WalletBalance}");
        }//ShowWalletBalance end

    }
}