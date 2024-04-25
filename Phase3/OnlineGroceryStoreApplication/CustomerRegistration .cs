using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public class CustomerRegistration:PersonalDetails,IBalance 
    { 
        //CustomerID {Auto Increment – CID1000}, WalletBalance
       //static  feild
       private static int s_customerID=1000;
       //feild
       private int _balance;
       //property
       public string CustomerID { get; set; }     
       public int WalletBalance { get{return _balance;} set{_balance=value;}}

       //constructor 
       
       //CustomerID	WalletBalance	Name	FatherName	Gender	Mobile	DOB	MailID
       public CustomerRegistration(int walletBalance,string userName,string fatherName,Gender gender,long mobile,DateTime dob,string mailID):base( userName, fatherName,gender, mobile,dob, mailID ){
        s_customerID++;
        CustomerID="CID"+s_customerID;   
        WalletBalance=walletBalance;     
       }

       //methods
        public void WalletRecharge(int rechargeAmount){
            
            WalletBalance=WalletBalance+rechargeAmount;
        }
        
        
    }
}