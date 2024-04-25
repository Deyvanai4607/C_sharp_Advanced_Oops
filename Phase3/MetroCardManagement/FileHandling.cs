using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static class FileHandling
    {
        //create folder and file
        public static void Create(){
            //folder creation
            if(!Directory.Exists("MetroCardManagement")){
                Directory.CreateDirectory("MetroCardManagement");
            }
            //file creation
            //user detail file
            if(!File.Exists("MetroCardManagement/UserDetails.csv")){
                File.Create("MetroCardManagement/UserDetails.csv").Close();
            }
            //TravelDetails file
            if(!File.Exists("MetroCardManagement/TravelDetails.csv")){
                File.Create("MetroCardManagement/TravelDetails.csv").Close();
            }
            //TicketFair file
            if(!File.Exists("MetroCardManagement/TicketFair.csv")){
                File.Create("MetroCardManagement/TicketFair.csv").Close();
            }
        }
        //write csv file
        public static void WriteCSV(){
            //user detail file
            string[] users=new string[Operation.userDetailsList.Count];
            for(int i=0;i<Operation.userDetailsList.Count;i++){
                users[i]=Operation.userDetailsList[i].CardNumber+","+Operation.userDetailsList[i].UserName+","+Operation.userDetailsList[i].PhoneNumber+","+Operation.userDetailsList[i].Balance;
            }
            File.WriteAllLines("MetroCardManagement/UserDetails.csv",users);
            //TravelDetails file
            string[] travels=new string[Operation.travelDetailsList.Count];
            for(int i=0;i<Operation.travelDetailsList.Count;i++){
                //string cardNumber,string fromLocation,string toLocation,DateTime date,int travelCost 
                travels[i]=Operation.travelDetailsList[i].TravelId+","+Operation.travelDetailsList[i].CardNumber+","+Operation.travelDetailsList[i].FromLocation+","+Operation.travelDetailsList[i].ToLocation+","+Operation.travelDetailsList[i].Date.ToString("dd/MM/yyyy")+","+Operation.travelDetailsList[i].TravelCost;
            }
            File.WriteAllLines("MetroCardManagement/TravelDetails.csv",travels);
            //TicketFair file
            string[] tickets=new string[Operation.ticketFairList.Count];
            for(int i=0;i<Operation.ticketFairList.Count;i++){
                //string fromLocation,string toLocation,int ticketPrice
                tickets[i]=Operation.ticketFairList[i].TicketID+","+Operation.ticketFairList[i].FromLocation+","+Operation.ticketFairList[i].ToLocation+","+Operation.ticketFairList[i].TicketPrice;
            }
            File.WriteAllLines("MetroCardManagement/TicketFair.csv",tickets);
        }
        //read from csv file   
        public static void ReadFromCSV(){
            //user detail file
            string[] users=File.ReadAllLines("MetroCardManagement/UserDetails.csv");
            foreach(string user in users){
                string[] userDetail =user.Split(",");
                UserDetails user1=new UserDetails(userDetail[0],userDetail[1],long.Parse(userDetail[2]),int.Parse(userDetail[3]));
                Operation.userDetailsList.Add(user1);
            }
            //TravelDetails file
            string[] travels=File.ReadAllLines("MetroCardManagement/TravelDetails.csv");
            foreach(string travel in travels){
                TravelDetails travel1=new TravelDetails(travel);
                Operation.travelDetailsList.Add(travel1);
            }
            //TicketFair file
            string[] tickets=File.ReadAllLines("MetroCardManagement/TicketFair.csv");
            foreach(string ticket in tickets){
                TicketFair ticket1=new TicketFair(ticket);
                Operation.ticketFairList.Add(ticket1);
            }

        }
    }
}