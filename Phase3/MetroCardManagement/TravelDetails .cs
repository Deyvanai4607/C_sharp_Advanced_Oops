using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// TravelDetails class used to store a Travel details
    /// </summary>
    public class TravelDetails 
    {
        /*Properties:
        a.	TravelId (Auto Generated -TID2001)
        b.	Card Number
        c.	FromLocation
        d.	ToLocation
        e.	Date
        f.	Travel Cost
        */
        //static feild
        private static int s_travelId=2000;
        //Properties
        public string TravelId { get; set; }
        public string CardNumber { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime Date { get; set; }
        public int TravelCost { get; set; }
        //constructor
        /// <summary>
        /// This is used to store a Travel detail of user
        /// </summary>
        /// <param name="cardNumber">This is card number of user</param>
        /// <param name="fromLocation">This is store from location of user</param>
        /// <param name="toLocation">This is store to location of user</param>
        /// <param name="date"></param>
        /// <param name="travelCost"></param>
        public TravelDetails(string cardNumber,string fromLocation,string toLocation,DateTime date,int travelCost  ){
            s_travelId++;
            TravelId="TID"+s_travelId;
            CardNumber=cardNumber;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            Date=date;
            TravelCost=travelCost;
        }
        public TravelDetails(string travel){
            //TravelID	CardNumber	FromLocation	ToLocation	Date	TravelCost
            string[] trav=travel.Split(",");
            
            TravelId=trav[0];
            s_travelId=int.Parse(trav[0].Remove(0,3));
            CardNumber=trav[1];
            FromLocation=trav[2];
            ToLocation=trav[3];
            Date=DateTime.ParseExact(trav[4],"dd/MM/yyyy",null);
            TravelCost=int.Parse(trav[5]);
        }
           
    }
}