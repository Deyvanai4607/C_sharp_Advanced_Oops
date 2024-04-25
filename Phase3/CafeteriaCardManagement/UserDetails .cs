using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public class UserDetails:PersonalDetails,IBalance 
    {
        /*•	UserID (Auto – SF1001)
        •	WorkStationNumber
        •	Field: _balance
        •	Read only property: WalletBalance.
        */    
       //static  feild
       private static int s_userID=1000;
       //feild
       private int _balance;
       //property
       public string UserID { get; set; }     
       public string WorkStationNumber { get; set; }
       public int WalletBalance { get{return _balance;} set{_balance=value;}}//read only

       //constructor 
       //UserID	UserName	FatherName	MobileNumber	MailID	Gender	WorkStationNumber	Balance
       public UserDetails(string userName,string fatherName,long mobile,string mailID,Gender gender,string workStationNumber,int walletBalance):base( userName, fatherName, mobile, mailID, gender){
        s_userID++;
        UserID="SF"+s_userID;  
        WorkStationNumber=workStationNumber; 
        WalletBalance=walletBalance;     
       }

       //methods
        public void WalletRecharge(int rechargeAmount){
            
            WalletBalance=WalletBalance+rechargeAmount;
        }
        public void DeductAmount(int deductAmount){
            
            WalletBalance=WalletBalance-deductAmount;
        }
        
    }
}