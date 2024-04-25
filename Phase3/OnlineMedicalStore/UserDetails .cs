using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class UserDetails:PersonalDetails, IWallet 
    {
        /*Properties:
        1.	UserID (Auto Increment – UID1001)
        2.	WalletBalance
            Methods:
        1.	Wallet Recharge
        2.	Deduct Balance
        */
        //static feild
        private static int s_userID=1000;
        //properties
        public string UserID { get; set; }
        public int WalletBalance { get; set; }
        //constructor
        public UserDetails(string name,int age,string city,string phoneNumber,int balance):base( name, age, city, phoneNumber){
            s_userID++;
            UserID="UID"+s_userID;
            WalletBalance=balance;
        }

        public UserDetails(string userID,string name,int age,string city,string phoneNumber,int balance):base( name, age, city, phoneNumber){
            
            UserID=userID;
            s_userID=int.Parse(userID.Remove(0,3));
            WalletBalance=balance;
        }
        //methods
        public void WalletRecharge(int rechargeAmount){
            WalletBalance=WalletBalance+rechargeAmount;            
        }
        public void DeductBalance(int rdeductAmount){
            WalletBalance=WalletBalance-rdeductAmount;            
        }
    }
}