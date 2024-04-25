using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// TicketFair class is used to store the Ticket fair details 
    /// </summary>
    public class TicketFair 
    {
        /*Properties:
        •	TicketID (Auto Generated – MR3001)
        •	FromLocation
        •	ToLocation
        •	TicketPrice
        */
        //static feild
        private static int s_ticketID=3000;
        //properties
        public string TicketID { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public int TicketPrice { get; set; }
        //constructor
        /// <summary>
        /// This constructor used to store a Travel Fair details
        /// </summary>
        /// <param name="fromLocation">This is store from location of user</param>
        /// <param name="toLocation">This is store to location of user</param>
        /// <param name="ticketPrice">This is store Ticket price of the travel</param>
        public TicketFair(string fromLocation,string toLocation,int ticketPrice){
            s_ticketID++;
            TicketID="MR"+s_ticketID;   
            FromLocation=fromLocation; 
            ToLocation=toLocation;  
            TicketPrice=ticketPrice;      
        }
        public TicketFair(string ticket){
            string[] tick=ticket.Split(",");
            
            TicketID=tick[0];  
            s_ticketID=int.Parse(tick[0].Remove(0,2));
            FromLocation=tick[1]; 
            ToLocation=tick[2];  
            TicketPrice=int.Parse(tick[3]);      
        }
        
        
        
        
        
        
    }
}