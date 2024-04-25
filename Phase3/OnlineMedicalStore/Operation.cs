using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace OnlineMedicalStore
{
    public static class Operation
    {
        static UserDetails currentUser;
        //Lists
        public static CustomList<UserDetails> userDetailsList=new CustomList<UserDetails>();
        public static CustomList<MedicineDetails> medicineDetailsList=new CustomList<MedicineDetails>();
        public static CustomList<OrderDetails > orderDetailsList=new CustomList<OrderDetails>();
        //adding default values
        public static void DefaultValues(){
            //user details
            UserDetails user1=new UserDetails( "Ravi",33,"Theni","9877774440",400);
            UserDetails user2=new UserDetails("Baskaran",33,"Chennai","8847757470",500);
            userDetailsList.AddRange(new CustomList<UserDetails>(){user1,user2});
            
            //MedicineDetails  
            MedicineDetails medicine1=new MedicineDetails("Paracitamol",40,5,new DateTime(2024,06,30));
            MedicineDetails medicine2=new MedicineDetails("Calpol",10,5,new DateTime(2024,05,30));
            MedicineDetails medicine3=new MedicineDetails("Gelucil",3,40,new DateTime(2023,04,30));
            MedicineDetails medicine4=new MedicineDetails("Metrogel",5,50,new DateTime(2024,12,30));
            MedicineDetails medicine5=new MedicineDetails("Povidin Iodin",10,50,new DateTime(2024,10,30));
            medicineDetailsList.AddRange(new CustomList<MedicineDetails>(){medicine1,medicine2,medicine3,medicine4,medicine5});

            //order details
            OrderDetails order1=new OrderDetails("UID1001","MD101",3,15,new DateTime(2022,11,13),OrderStatus.Purchased);
            OrderDetails order2=new OrderDetails("UID1001","MD102",2,10,new DateTime(2022,11,13),OrderStatus.Cancelled);
            OrderDetails order3=new OrderDetails("UID1001","MD104",2,100,new DateTime(2022,11,13),OrderStatus.Purchased);
            OrderDetails order4=new OrderDetails("UID1002","MD103",3,120,new DateTime(2022,11,15),OrderStatus.Cancelled);
            OrderDetails order5=new OrderDetails("UID1002","MD105",5,250,new DateTime(2022,11,15),OrderStatus.Purchased);
            OrderDetails order6=new OrderDetails("UID1002","MD102",3,15,new DateTime(2022,11,15),OrderStatus.Purchased);
            orderDetailsList.AddRange(new CustomList<OrderDetails>(){order1,order2,order3,order4,order5,order6});       
        
        }//default values end
        //main menu
        public static void MainMenu(){
            string mainChoice="yes";
            do{
                /*1.	User Registration
                    2.	User Login
                    3.	Exit
                    */
                Console.WriteLine("Select option\n1.User Registration\n2.User Login\n3.Exit ");
                int option=int.Parse(Console.ReadLine());
                switch(option){
                    case 1:{
                        Console.WriteLine("************User Registration***********");
                        UserRegistration();
                        break;
                    }case 2:{
                        Console.WriteLine("************User Login***********");
                        UserLogin();
                        break;
                    }case 3:{
                        Console.WriteLine("************Exit successfully***********");
                        mainChoice="no";
                        break;
                    }
                }         

            }while(mainChoice=="yes");
        }//main menu end
        //UserRegistration
        public static void UserRegistration(){
            /*a.	Username
            b.	Age
            c.	City
            d.	Phone Number
            e.	Balance
            */
            //get user details from user
            Console.Write("Enter user name : ");
            string name=Console.ReadLine();
            Console.Write("Enter user Age : ");
            int age=int.Parse(Console.ReadLine());
            Console.Write("Enter user City : ");
            string city=Console.ReadLine();
            Console.Write("Enter user Phone Number : ");
            string phoneNumber=Console.ReadLine();
            Console.Write("Enter user Wallet Balance : ");
            int walletBalance=int.Parse(Console.ReadLine());
            //object creation
            UserDetails user=new UserDetails(name,age,city,phoneNumber,walletBalance);
            //add to list
            userDetailsList.Add(user);
            //display user id
            Console.WriteLine($"User registration is successfully done and user ID is {user.UserID}");
        }//UserRegistration end
        //UserLogin
        public static void UserLogin(){
            //get user id
            Console.WriteLine("Enter your user ID");
            String userId=Console.ReadLine().ToUpper();
            //validate the user id
            bool flag=true;
            foreach(UserDetails user in userDetailsList){
                if(userId.Equals(user.UserID)){
                    flag=false;
                    currentUser=user;
                    //create sub menu
                    SubMenu();
                    break;
                }
            }
            if(flag){
                Console.WriteLine("Invalid User ID. Please enter a valid one");
            }
        }//UserLogin end 
        //SubMenu
        public static void SubMenu(){
            /*a.	Show medicine list.
            b.	Purchase medicine.
            c.	Modify purchase.
            d.	Cancel purchase.
            e.	Show purchase history.
            f.	Recharge Wallet.
            g.	Show Wallet Balance
            h.	Exit
            */
            string subChoice="yes";
            do{
                Console.WriteLine("Select option\n1.Show medicine list\n2.Purchase medicine\n3.Modify purchase\n4.Cancel purchase\n5.Show purchase history\n6.Recharge Wallet\n7.Show Wallet Balance\n8.Exit");
                int subOption=int.Parse(Console.ReadLine());
                switch(subOption){
                    case 1:{
                        Console.WriteLine("************medicine list*************");
                        ShowMedicineList();
                        break;
                    }case 2:{
                        Console.WriteLine("************Purchase medicine*************");
                        PurchaseMedicine();
                        break;
                    }case 3:{
                        Console.WriteLine("************Modify purchase*************");
                        ModifyPurchase();
                        break;
                    }case 4:{
                        Console.WriteLine("************Cancel purchase*************");
                        CancelPurchase();
                        break;
                    }case 5:{
                        Console.WriteLine("************Show purchase History*************");
                        ShowPurchaseHistory();
                        break;
                    }case 6:{
                            Console.WriteLine("************Recharge Wallet*************");
                            
                            RechargeWallet();
                            
                            
                            break;
                    }case 7:{
                        Console.WriteLine("************Wallet Balance*************");
                        WalletBalance();
                        break;    
                    }case 8:{
                        Console.WriteLine("************Exit sucessfully*************");
                        subChoice="no";
                        break;
                    }
                }
            }while(subChoice=="yes");
        }//SubMenu end
        //ShowmedicineList
        public static void ShowMedicineList(){
         System.Console.WriteLine($"|{"MedicineID",-15}|{"MedicineName",-15}|{"AvailableCount",-15}|{"Price",-15}|{"DateOfExpiry",-15}|");
         foreach(MedicineDetails medicine in medicineDetailsList){
            System.Console.WriteLine($"|{medicine.MedicineID,-15}|{medicine.MedicineName,-15}|{medicine.AvailableCount,-15}|{medicine.Price,-15}|{medicine.DateOfExpiry,-15}|");
         }
        }//ShowmedicineList end
        //PurchaseMedicine
        public static void PurchaseMedicine(){
            ShowMedicineList();
            System.Console.Write("select the medicine using MedicineID : ");
            string medicineId=Console.ReadLine().ToUpper();
            System.Console.Write("Enter number of counts of that medicine you wants to buy : ");
            int medicineCount=int.Parse(Console.ReadLine());
            //check medicime Id
            foreach(MedicineDetails medicine in medicineDetailsList){
                if(medicineId.Equals(medicine.MedicineID)){
                    if(medicineCount<=medicine.AvailableCount){
                        if(DateTime.Compare(DateTime.Now,medicine.DateOfExpiry)<0){
                            if(currentUser.WalletBalance>=medicineCount*medicine.Price){
                                medicine.AvailableCount=medicine.AvailableCount-medicineCount;
                                currentUser.DeductBalance(medicineCount*medicine.Price);
                                int totalAmount=medicineCount*medicine.Price;
                                OrderDetails order=new OrderDetails(currentUser.UserID,medicine.MedicineID,medicineCount,totalAmount,DateTime.Now,OrderStatus.Purchased);
                                orderDetailsList.Add(order);
                                System.Console.WriteLine("Medicine was purchased successfully");                                
                            }else{
                                System.Console.WriteLine("you have insufficient balance go to recharge... ");
                            }
                        }else{
                            System.Console.WriteLine("Medicine is not available");
                        }
                    }else{
                        System.Console.WriteLine("Medicine is not available");
                    }
                } 
            }

        }//PurchaseMedicine end
        //ModifyPurchase
        public static void ModifyPurchase(){
            System.Console.WriteLine($"|{"OrderID",-15}|{"UserID",-15}|{"MedicineID",-15}|{"MedicineCount",-15}|{"TotalPrice",-15}|{"OrderDate",15}|{"OrderStatus",-15}|");
            foreach(OrderDetails order in orderDetailsList){
                if(currentUser.UserID.Equals(order.UserID)&& order.OrderStatus==OrderStatus.Purchased){
                    System.Console.WriteLine($"|{order.OrderID,-15}|{order.UserID,-15}|{order.MedicineID,-15}|{order.MedicineCount,-15}|{order.TotalPrice,-15}|{order.OrderDate,15}|{order.OrderStatus,-15}|");
                }
            } 
            System.Console.WriteLine(" pick a order detail by using OrderID");  
            string orderId=Console.ReadLine().ToUpper();     
            foreach(OrderDetails order in orderDetailsList){
                if(orderId.Equals(order.OrderID)){
                    System.Console.WriteLine("enter the new quantity of the medicine : ");
                    int newQuantity=int.Parse(Console.ReadLine());
                    foreach(MedicineDetails medicine in medicineDetailsList){
                        if(medicine.MedicineID.Equals(order.MedicineID)){
                            int newTotal=newQuantity*medicine.Price;
                            order.MedicineCount=newQuantity;
                            order.TotalPrice=newTotal;
                            System.Console.WriteLine("order modified successfully...");
                        }
                    }
                }
            }              

        }//ModifyPurchase end
        //CancelPurchase
        public static void CancelPurchase(){
            System.Console.WriteLine($"|{"OrderID",-15}|{"UserID",-15}|{"MedicineID",-15}|{"MedicineCount",-15}|{"TotalPrice",-15}|{"OrderDate",15}|{"OrderStatus",-15}|");
            foreach(OrderDetails order in orderDetailsList){
                if(currentUser.UserID.Equals(order.UserID)&& order.OrderStatus==OrderStatus.Purchased){
                    System.Console.WriteLine($"|{order.OrderID,-15}|{order.UserID,-15}|{order.MedicineID,-15}|{order.MedicineCount,-15}|{order.TotalPrice,-15}|{order.OrderDate,15}|{order.OrderStatus,-15}|");
                }
            } 
            System.Console.WriteLine(" pick a order detail by using OrderID");  
            string orderId=Console.ReadLine().ToUpper();  
            foreach(OrderDetails order in orderDetailsList){
                if(orderId.Equals(order.OrderID)){
                    foreach(MedicineDetails medicine in medicineDetailsList){
                        if(medicine.MedicineID.Equals(order.MedicineID)){
                            medicine.AvailableCount=medicine.AvailableCount+order.MedicineCount;
                            currentUser.WalletRecharge(order.TotalPrice);
                            order.OrderStatus=OrderStatus.Cancelled;
                            System.Console.WriteLine($"{order.OrderID}  was cancelled successfully");
                        }
                    }                
                }
            }              

        }//CancelPurchase end
        //ShowPurchaseHistory
        public static void ShowPurchaseHistory(){
            System.Console.WriteLine($"|{"OrderID",-15}|{"UserID",-15}|{"MedicineID",-15}|{"MedicineCount",-15}|{"TotalPrice",-15}|{"OrderDate",15}|{"OrderStatus",-15}|");
            foreach(OrderDetails order in orderDetailsList){
                if(currentUser.UserID.Equals(order.UserID)){
                    System.Console.WriteLine($"|{order.OrderID,-15}|{order.UserID,-15}|{order.MedicineID,-15}|{order.MedicineCount,-15}|{order.TotalPrice,-15}|{order.OrderDate,15}|{order.OrderStatus,-15}|");
                }
            } 
        }//ShowPurchaseHistory end
        //RechargeWallet
        public static void RechargeWallet(){
            System.Console.Write ("Enter a recharge amount : ");
            int amount=int.Parse(Console.ReadLine());
            currentUser.WalletRecharge(amount);
        }//RechargeWallet end
        //WalletBalance
        public static void WalletBalance(){
            System.Console.WriteLine($"{currentUser.Name} current balance is {currentUser.WalletBalance}");
        }//WalletBalance end
        

    }
}