using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This class is used to perform a operation
    /// </summary>
    public static class Operation
    {
        public static UserDetails currentUser;
        public static CustomList<UserDetails> userDetailsList=new CustomList<UserDetails>();
        public static CustomList<TravelDetails> travelDetailsList=new CustomList<TravelDetails>();
        public static CustomList<TicketFair> ticketFairList=new CustomList<TicketFair>();
        //default values
        public static void DefaultValues(){
            //add user details
            UserDetails user1=new UserDetails("Ravi",9848812345,1000);
            UserDetails user2=new UserDetails("Baskaran",9948854321,1000);
            userDetailsList.Add(user1);
            userDetailsList.Add(user2);

            //add travel details
            //TravelID	CardNumber	FromLocation	ToLocation	Date	TravelCost
            TravelDetails travel1=new TravelDetails("CMRL1001","Airport","Egmore",new DateTime(2023,10,10),55);
            TravelDetails travel2=new TravelDetails("CMRL1001","Egmore","Koyambedu",new DateTime(2023,10,10),32);
            TravelDetails travel3=new TravelDetails("CMRL1002","Alandur","Koyambedu",new DateTime(2023,11,10),25);
            TravelDetails travel4=new TravelDetails("CMRL1002","Egmore","Thirumangalam",new DateTime(2023,11,10),25);
            travelDetailsList.Add(travel1);
            travelDetailsList.Add(travel2);
            travelDetailsList.Add(travel3);
            travelDetailsList.Add(travel4);

            //add TicketFair
            //TicketID	FromLocation	ToLocation	Fair
            TicketFair ticket1=new TicketFair("Airport","Egmore",55);
            TicketFair ticket2=new TicketFair("Airport","Koyambedu",25);
            TicketFair ticket3=new TicketFair("Alandur","Koyambedu",25); 
            TicketFair ticket4=new TicketFair("Koyambedu","Egmore",32);
            TicketFair ticket5=new TicketFair("Vadapalani","Egmore",45);
            TicketFair ticket6=new TicketFair("Arumbakkam","Egmore",25);
            TicketFair ticket7=new TicketFair("Vadapalani","Koyambedu",25);
            TicketFair ticket8=new TicketFair("Arumbakkam","Koyambedu",16);   
            ticketFairList.Add(ticket1);
            ticketFairList.Add(ticket2);
            ticketFairList.Add(ticket3);
            ticketFairList.Add(ticket4);
            ticketFairList.Add(ticket5);
            ticketFairList.Add(ticket6);
            ticketFairList.Add(ticket7);
            ticketFairList.Add(ticket8);
        }//default values end
        //main menu
        public static void MainMenu(){
            /*1.	New User Registration
            2.	Login User
            3.	Exit
            */
            string mainChoice="yes";
            do{
                System.Console.WriteLine("Select Option\n1.New User Registration\n2.Login User\n3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option){
                    case 1:{
                        System.Console.WriteLine("**************New User Registration**************");
                        NewUserRegistration();
                        break;
                    }case 2:{
                        System.Console.WriteLine("**************Login User**************");
                        LoginUser();
                        break;
                    }case 3:{
                        System.Console.WriteLine("**************Exit**************");
                        mainChoice="no";
                        break;
                    }
                }
            }while(mainChoice=="yes");
        }//main menu end
        //NewUserRegistration method
        public static void NewUserRegistration(){
            //get user details
            /*•	UserName
            •	Phone Number
            •	Balance
            */
            System.Console.Write ("Enter user Name :");
            string userName=Console.ReadLine();
            System.Console.Write ("Enter user Phone Number :");
            long phoneNumber=long.Parse(Console.ReadLine());
            System.Console.Write ("Enter user Balance :");
            int balance=int.Parse(Console.ReadLine());            
            //create object
            UserDetails user=new UserDetails(userName,phoneNumber,balance);
            //add to list
            userDetailsList.Add(user);
            //display card number
            System.Console.WriteLine($"your card number is {user.CardNumber}");
        }//NewUserRegistration end
        //LoginUser method
        public static void LoginUser(){
            //get card number 
            System.Console.Write ("Enter your card Number : ");
            string cardnumber=Console.ReadLine().ToUpper();
            //ckeck the card number
            bool flag=true;
            foreach(UserDetails user in userDetailsList){
                if(cardnumber.Equals(user.CardNumber)){
                    currentUser=user;
                    SubMenu();
                    flag=false;
                    break;
                }
            }
            if(flag){
                System.Console.WriteLine("the card number you entered is not a valid one");
            }


        }//LoginUser end
        //SubMenu
        public static void SubMenu(){
            System.Console.WriteLine("***************Sub Menu**************");
            /*a.	Balance Check
            b.	Rechange
            c.	View Travel History	
            d.	Travel
            e.	Exit 
            */
            string subChoice="yes";
            do{
                System.Console.WriteLine("Select sub option\n1.Balance Check\n2.Rechange\n3.View Travel History\n4.Travel\n5.Exit ");
                int subOption=int.Parse(Console.ReadLine());
                switch(subOption){
                    case 1:{
                        System.Console.WriteLine("******************Balance Check*******************");
                        BalanceCheck();
                        break;
                    }case 2:{
                        System.Console.WriteLine("******************Rechange*******************");
                        Rechange();
                        break;
                    }case 3:{
                        System.Console.WriteLine("******************View Travel History*******************");
                        ViewTravelHistory();
                        break;
                    }case 4:{
                        System.Console.WriteLine("******************Travel*******************");
                        Travel();
                        break;
                    }case 5:{
                        System.Console.WriteLine("******************Exit*******************");
                        subChoice="no";
                        break;
                    }
                }
            }while(subChoice=="yes");
        }//SubMenu end
        //BalanceCheck
        public static void BalanceCheck(){
            System.Console.WriteLine($"Card number {currentUser.CardNumber} balance is {currentUser.Balance}");
        }//BalanceCheck end
        //Rechange
        public static void Rechange(){
            System.Console.Write ("Enter your recharge amount : ");
            int rechargeAmount=int.Parse(Console.ReadLine());
            currentUser.WalletRecharge(rechargeAmount);
        }//Rechange end
        //ViewTravelHistory
        public static void ViewTravelHistory(){
            System.Console.WriteLine($"|{"TravelID",-15}|{"CardNumber",-15}|{"FromLocation",-15}|{"ToLocation",-15}|{"Date",-15}|{"TravelCost",-15}|");
            foreach(TravelDetails travel in travelDetailsList){
                if(travel.CardNumber.Equals(currentUser.CardNumber)){
                    System.Console.WriteLine($"|{travel.TravelId,-15}|{travel.CardNumber,-15}|{travel.FromLocation,-15}|{travel.ToLocation,-15}|{travel.Date.ToString("dd/MM/yyyy"),-15}|{travel.TravelCost,-15}|");
                }
            }
        }//ViewTravelHistory end
        //Travel
        public static void Travel(){
            //TicketID	FromLocation	ToLocation	Fair
            System.Console.WriteLine($"|{"TicketID",-15}|{"FromLocation",-15}|{"ToLocation",-15}|{"Fair",-15}|");
            foreach(TicketFair fair in ticketFairList){
                System.Console.WriteLine($"{fair.TicketID,-15}|{fair.FromLocation,-15}|{fair.ToLocation,-15}|{fair.TicketPrice,-15}|");
            }
            System.Console.Write ("Choose one TicketID from above list : ");
            string ticketChoice=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(TicketFair fair in ticketFairList){
                if(ticketChoice.Equals(fair.TicketID)){
                    flag=false;
                    if(currentUser.Balance>=fair.TicketPrice){
                        currentUser.DeductBalance(fair.TicketPrice);
                        //string cardNumber,string fromLocation,string toLocation,DateTime date,int travelCost  
                        TravelDetails travel=new TravelDetails(currentUser.CardNumber,fair.FromLocation,fair.ToLocation,DateTime.Now,fair.TicketPrice);
                        travelDetailsList.Add(travel);
                    }else{
                        System.Console.WriteLine("You have Insufficient balance go to recharge ");
                    }
                    break;
                }
            }
            if(flag){
                System.Console.WriteLine("Invalid user id");
            }

        }//Travel end

    }
}