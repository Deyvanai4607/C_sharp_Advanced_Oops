using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public enum BookingStatus{Default,Initiated, Booked, Cancelled}
    public class BookingDetails 
    {
        //BookingID {Auto Increment – BID3000}, CustomerID, TotalPrice, DateOfBooking, Booking Status – Default, Initiated, Booked, Cancelled.
        //static field creation
        private static int s_bookingID=1000;
        //properties creation
        public string BookingID { get; }//read only
        public string CustomerID { get; set; }
        public int TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        
        public BookingStatus BookingStatus { get; set; }        
        //Contructor creation
        public BookingDetails(string customerID,int totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus){
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;            
            BookingStatus=bookingStatus;
        }
        //ShowBookingDetails method
        public void ShowBookingDetails(string bookingID){
            System.Console.WriteLine($"|{"BookingID",-15}|{"CustomerID",-15}|{"TotalPrice",-15}|{"DateOfBooking",-15}|{"BookingStatus",-15}|");
            if(bookingID.Equals(BookingID)){    
                System.Console.WriteLine($"|{BookingID,-15}|{CustomerID,-15}|{TotalPrice,-15}|{DateOfBooking,-15}|{BookingStatus,-15}");            
            }
        }
    }
}