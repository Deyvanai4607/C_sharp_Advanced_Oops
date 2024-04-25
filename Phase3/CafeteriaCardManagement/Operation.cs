using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public static class Operation
    {
        static UserDetails currentUser;
        static OrderDetails currentOrder;
         //lists
        static CustomList<UserDetails> userDetailsList=new CustomList<UserDetails>();
        static CustomList<OrderDetails> orderDetailsList=new CustomList<OrderDetails>();
        static CustomList<CartItem> cartItemList=new CustomList<CartItem>();
        static CustomList<FoodDetails> foodDetailsList=new CustomList<FoodDetails>();

        public static void DefaultValues(){
 

            UserDetails user1=new UserDetails("Ravichandran","Ettapparajan",8857777575 ,"ravi@mail.com",Gender.Male,"WS101",400);
            UserDetails user2=new UserDetails("Baskaran","Sethurajan",9577747744 ,"baskaran@mail.com",Gender.Male,"WS105",500);
            userDetailsList.AddRange(new CustomList<UserDetails>(){user1,user2});

            OrderDetails order1=new OrderDetails("SF1001" ,new DateTime(2022,06,15),70,OrderStatus.Ordered);
            OrderDetails order2=new OrderDetails("SF1002" ,new DateTime(2022,06,15),100,OrderStatus.Ordered);
            orderDetailsList.AddRange(new CustomList<OrderDetails>(){order1,order2});  

            CartItem product1=new CartItem("OID1001","FID101",20,1);
            CartItem product2=new CartItem("OID1001","FID103",10,1);
            CartItem product3=new CartItem("OID1001","FID105",40,1);
            CartItem product4=new CartItem("OID1002","FID103",10,1);
            CartItem product5=new CartItem("OID1002","FID104",50,1);
            CartItem product6=new CartItem("OID1002","FID105",40,1);
            cartItemList.AddRange(new CustomList<CartItem>(){product1,product2,product3,product4,product5,product6 });
   
            FoodDetails food1=new FoodDetails("Coffee",20,100);
            FoodDetails food2=new FoodDetails("Tea",15,100);
            FoodDetails food3=new FoodDetails("Biscuit",10,100);
            FoodDetails food4=new FoodDetails("Juice",50,100);
            FoodDetails food5=new FoodDetails("Puff",40,100);
            FoodDetails food6=new FoodDetails("Milk",10,100);
            FoodDetails food7=new FoodDetails("Popcorn",20,20);
            foodDetailsList.AddRange(new CustomList<FoodDetails>(){food1,food2,food3,food4,food5,food6,food7});
   
        } //add default values end   

        //main menu
        /*1.	User Registration
        2.	User Login
        3.	Exit
        */
        public static void MainMenu(){
            Console.WriteLine("********************Welcome to Cafeteria *************************");
            string mainChoice="yes";
            do{
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
        } //main menu end  

        //UserRegistration
        /*a.	Username
        b.	Father Name
        c.	Mobile Number
        d.	MailID
        e.	Gender 
        f.	WorkStationNumber (WS101) 
        g.	Balance
        */
        public static void UserRegistration(){
            //get user details from user
            Console.Write("Enter user name : ");
            string name=Console.ReadLine();
            Console.Write("Enter user Father Name : ");
            string fatherName=Console.ReadLine();
            Console.Write("Enter user Phone Number : ");
            long phoneNumber=long.Parse(Console.ReadLine());
            Console.Write("Enter user Mail ID : ");
            string mailID=Console.ReadLine();
            Console.Write("Enter user Gender : ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter user WorkStationNumber (WS101) : ");
            string workStationNumber=Console.ReadLine();
            Console.Write("Enter user Wallet Balance : ");
            int walletBalance=int.Parse(Console.ReadLine());
            //object creation
            UserDetails user=new UserDetails(name,fatherName,phoneNumber,mailID,gender,workStationNumber,walletBalance);
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
                Console.WriteLine("Invalid userID");
            }
        }//UserLogin end
        //submenu
        /*Show My Profile
        b.	 Food Order
        c.	 Modify Order
        d.	 Cancel Order
        e.	 Order History
        f.	 Wallet Recharge
        g.	Show WalletBalance
        h.	 Exit
        */
        public static void SubMenu(){
            string subChoice="yes";
            do{
                Console.WriteLine("Select option\n1.Show My Profile\n2.Food Order\n3.Modify Order\n4.Cancel Order\n5.Order History\n6.WalletRecharge\n7.Show Wallet Balance\n8.Exit");
                int subOption=int.Parse(Console.ReadLine());
                switch(subOption){
                    case 1:{
                        Console.WriteLine("************My Profile*************");
                        ShowMyProfile();
                        break;
                    }case 2:{
                        Console.WriteLine("************Food Order*************");
                        FoodOrder();
                        break;
                    }case 3:{
                        Console.WriteLine("************Modify Order*************");
                        ModifyOrder();
                        break;
                    }case 4:{
                        Console.WriteLine("************Cancel Order*************");
                        CancelOrder();
                        break;
                    }case 5:{
                        Console.WriteLine("************Order History*************");
                        OrderHistory();
                        break;
                    }case 6:{
                            Console.WriteLine("************WalletRecharge*************");
                            Console.WriteLine("Do you want to recharge your wallet ? yes/no");
                            string answer = Console.ReadLine();
                            if(answer=="yes"){
                                WalletRecharge();
                            }else{
                                subChoice="no";                                
                            }
                            
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
        }//sub menu end
        //ShowMyProfile
      
        public static void ShowMyProfile(){
            
            foreach(UserDetails user in userDetailsList){
                if(currentUser.UserID.Equals(user.UserID)){
                    Console.WriteLine($"user’s personal details\nUser Name : {user.Name}\nFatherName : {user.FatherName}\nGender : {user.Gender}\nMobile : {user.Mobile}\nMailID : {user.MailID}\nWallet Balance : {user.WalletBalance}");
                }
            }
        }//ShowMyProfile end
        //FoodOrder 
        public static void FoodOrder(){
            
            CustomList<CartItem> localCarItemtList=new CustomList<CartItem>();
            string answer="no";
            do{
                    Console.WriteLine($"|{"FoodID",-10}|{"FoodName",-10}|{"Price",-10}|{"AvailableQuantity",-17}|");
                    foreach(FoodDetails food in foodDetailsList)  {
                        Console.WriteLine($"|{food.FoodID,-10}|{food.FoodName,-10}|{food.FoodPrice,-10}|{food.AvailableQuantity,-17}|");
                    }    
                        //order object
                    OrderDetails order=new OrderDetails(currentUser.UserID,DateTime.Now ,0,OrderStatus.Initiated);
                    currentOrder=order;
                    //Ask the user to pick a product using FoodID, quantity 
                    Console.Write("Enter the product using FoodID : ");
                    string foodId=Console.ReadLine();
                    Console.Write("Enter the quantity you want : ");
                    int quantity=int.Parse(Console.ReadLine());  
                    //calculate price of the food
                    int priceOfTheFood=0;
                    foreach(FoodDetails food in foodDetailsList)  {
                        if(food.FoodID.Equals(foodId)){
                             priceOfTheFood=  food.FoodPrice*quantity;
                            
                        }
                    }
                    foreach(FoodDetails food in foodDetailsList)  {
                        if(food.FoodID.Equals(foodId)){
                            //check food and quantity available
                            if(food.AvailableQuantity>=quantity){
                                food.AvailableQuantity=food.AvailableQuantity-quantity;
                                //CartItems object //ItemID	OrderID	FoodID	OrderPrice	OrderQuantity
                                CartItem cart=new CartItem(order.OrderID,food.FoodID,priceOfTheFood, quantity );
                                localCarItemtList.Add(cart);
                                // order.TotalPrice=priceOfTheFood;
                                // order.OrderStatus=OrderStatus.Ordered;
                                // orderDetailsList.Add(order);
                            }
                        }
                    }
                    //Ask the user whether he want to pick another product
                    Console.Write("Do you want to pick another product (yes/no) : ");
                    answer=Console.ReadLine();
              }while(answer=="yes");
              string confirmAnswer="no";
              if(answer=="no"){
                Console.Write("Do you confirm the wish list to purchase (yes/no) : ");
                confirmAnswer=Console.ReadLine();
              }
              if(confirmAnswer=="no"){
                foreach(CartItem item in localCarItemtList){
                    foreach(FoodDetails food in foodDetailsList)  {
                        if(item.FoodID.Equals(food.FoodID)){
                            food.AvailableQuantity=food.AvailableQuantity+item.OrderQuantity;                                                                                    
                        }
                    }                    
                }
              }else if(confirmAnswer=="yes"){
                int totalAmount=0;
                foreach(CartItem item in localCarItemtList){
                       totalAmount=totalAmount+item.OrderPrice  ;            
                } 
                if(totalAmount<=currentUser.WalletBalance){
                    currentUser.DeductAmount(totalAmount);
                    cartItemList.AddRange(localCarItemtList);
                    currentOrder.TotalPrice=totalAmount;
                    currentOrder.OrderStatus=OrderStatus.Ordered;   
                    orderDetailsList.Add(currentOrder);   
                    Console.WriteLine($"Order placed successfully, and OrderID is {currentOrder.OrderID}");            
                }else{
                    Console.WriteLine("In sufficient balance to purchase.");
                    Console.Write ("Are you willing to recharge (yes/no) : ");
                    string rechargeAnswer=Console.ReadLine();
                    if(rechargeAnswer=="no"){
                        foreach(CartItem item in localCarItemtList){
                            foreach(FoodDetails food in foodDetailsList)  {
                                if(item.FoodID.Equals(food.FoodID)){
                                    food.AvailableQuantity=food.AvailableQuantity+item.OrderQuantity;                                                                                    
                                }
                            }                    
                        }
                    }else if(rechargeAnswer=="yes"){
                        Console.Write("Do you Recharge with the total price of Order(yes/no) : ");
                        string priceAnswer=Console.ReadLine();
                        if(priceAnswer=="yes"){
                            currentUser.WalletRecharge(totalAmount);
                            currentUser.DeductAmount(totalAmount);
                            cartItemList.AddRange(localCarItemtList);
                            currentOrder.TotalPrice=totalAmount;
                            currentOrder.OrderStatus=OrderStatus.Ordered;   
                            orderDetailsList.Add(currentOrder);   
                            Console.WriteLine($"Order placed successfully, and OrderID is {currentOrder.OrderID}"); 
                        }

                    }  
                }             
              }
               
        }//FoodOrder end
        //ModifyOrder
        public static void ModifyOrder(){
            Console.WriteLine($"|{"OrderID",-10}|{"UserID",-10}|{"OrderDate",-19}|{"TotalPrice",-10}|{"OrderStatus",-10}|");
            foreach(OrderDetails order in orderDetailsList){
                if(currentUser.UserID.Equals(order.UserID)){
                    Console.WriteLine($"|{order.OrderID,-10}|{order.UserID,-10}|{order.OrderDate,-19}|{order.TotalPrice,-10}|{order.OrderStatus,-10}|");           
                }
            } 
            foreach(OrderDetails order in orderDetailsList){
                Console.WriteLine("pick an Order detail by using OrderID");
                string userOrderId=Console.ReadLine();
                if(userOrderId.Equals(order.OrderID) && order.OrderStatus==OrderStatus.Ordered){
                    //ItemID	OrderID	FoodID	OrderPrice	OrderQuantity
                   Console.WriteLine($"|{"ItemID",-10}|{"OrderID",-10}|{"FoodID",-10}|{"OrderPrice",-10}|{"OrderQuantity",-10}|");
                   foreach(CartItem item in cartItemList){
                    if(userOrderId.Equals(item.OrderID)){
                        Console.WriteLine($"|{item.ItemID,-10}|{item.OrderID,-10}|{item.FoodID,-10}|{item.OrderPrice,-10}|{item.OrderQuantity,-10}|");
                    }
                   }
                   Console.Write("Enter the Item ID which you want modify : ");
                   string modifyItemID=Console.ReadLine();
                   foreach(CartItem item in cartItemList){
                    if(modifyItemID.Equals(item.ItemID)){
                        Console.Write("enter the new quantity of the food : ");
                        int newQuantity=int.Parse(Console.ReadLine());
                        foreach(FoodDetails food in foodDetailsList){
                            if(item.FoodID.Equals(food.FoodID)){
                                int price=newQuantity*food.FoodPrice;
                                order.TotalPrice=(order.TotalPrice-item.OrderPrice)+price;
                                item.OrderPrice=price;
                                Console.WriteLine("Order modified successfully");
                                break;
                            }
                        }
                    }
                   }
                   break;
                }else{
                    Console.WriteLine("Invalid Order ID");
                }
            }            
        }//ModifyOrder end
        //CancelOrder
        public static void CancelOrder(){
            Console.WriteLine($"|{"OrderID",-10}|{"UserID",-10}|{"OrderDate",-19}|{"TotalPrice",-10}|{"OrderStatus",-10}|");
            foreach(OrderDetails order in orderDetailsList){
                if(currentUser.UserID.Equals(order.UserID)&& order.OrderStatus==OrderStatus.Ordered){
                    Console.WriteLine($"|{order.OrderID,-10}|{order.UserID,-10}|{order.OrderDate,-19}|{order.TotalPrice,-10}|{order.OrderStatus,-10}|");           
                }
            }  
            Console.Write("pick an OrderID to cancel : ");
            string pickOrderID=Console.ReadLine();   
            bool flag=true; 
            foreach(OrderDetails order in orderDetailsList){
                if(pickOrderID.Equals(order.OrderID)){
                    flag=false;
                    currentUser.WalletRecharge(order.TotalPrice);
                    foreach(CartItem item in cartItemList){
                        if(order.OrderID.Equals(item.OrderID)){
                            foreach(FoodDetails food in foodDetailsList){
                                if(food.FoodID.Equals(item.FoodID)){
                                   food.AvailableQuantity= food.AvailableQuantity+item.OrderQuantity;
                                   order.OrderStatus =OrderStatus.Cancelled;
                                   
                                }
                            }
                            
                        }
                    }
                    Console.WriteLine("Order cancelled successfully");
                    break;
                }
            }   
            if(flag){
                Console.WriteLine("Invalid OrderID");
            }    
        }//CancelOrder end
        //OrderHistory
        public static void OrderHistory(){
            Console.WriteLine($"|{"OrderID",-10}|{"UserID",-10}|{"OrderDate",-19}|{"TotalPrice",-10}|{"OrderStatus",-10}|");
            foreach(OrderDetails order in orderDetailsList){
                if(currentUser.UserID.Equals(order.UserID)){
                    Console.WriteLine($"|{order.OrderID,-10}|{order.UserID,-10}|{order.OrderDate,-19}|{order.TotalPrice,-10}|{order.OrderStatus,-10}|");
                }
            }            
        }//OrderHistory end
        //WalletRecharge
        public static void WalletRecharge(){
                Console.Write("Enter recharge amount : ");
                int rechargeAmount=int.Parse(Console.ReadLine());
                currentUser.WalletRecharge(rechargeAmount);
                Console.WriteLine($"your updated wallet balance is : {currentUser.WalletBalance}");            
        }//WalletRecharge end
        //WalletBalance
        public static void WalletBalance(){
            Console.WriteLine($"{currentUser.Name} wallet balance is {currentUser.WalletBalance}") ;            
        }//WalletBalance end

        
    }
  
}