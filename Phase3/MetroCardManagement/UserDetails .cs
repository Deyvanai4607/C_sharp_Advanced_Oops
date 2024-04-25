using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement;

    /// <summary>
    /// User Detail class is used to store a user details
    /// </summary>
    public class UserDetails:PersonalDetails,IBalance
    {
        /*Properties:
        •	CardNumber(Auto generation- CMRL1001)
        •	Balance
        Methods:
        •	WalletRecharge
        •	DeductBalance
        */
        //static feild
        private static int s_cardNumber=1000;
        //Properties
        public string CardNumber { get; set; }
        public int Balance { get; set; }
        //constructor
        public UserDetails(string userName,long phoneNumber,int balance):base( userName, phoneNumber){
            s_cardNumber++;
            CardNumber="CMRL"+s_cardNumber;
            Balance=balance;
        }
        public UserDetails(string cardNumber,string userName,long phoneNumber,int balance):base( userName, phoneNumber){
             
            CardNumber=cardNumber;
            s_cardNumber=int.Parse(cardNumber.Remove(0,4));
            Balance=balance;
        }
        // public UserDetails(string user){
        //     //users[i]=Operation.userDetailsList[i].CardNumber+","+Operation.userDetailsList[i].UserName+","+Operation.userDetailsList[i].PhoneNumber+","+Operation.userDetailsList[i].Balance;
        //     string[] userDetail=user.Split(",");
        //     CardNumber=userDetail[0];
        //     s_cardNumber=int.Parse(userDetail[0].Remove(0,4));
        //     Balance=int.Parse(userDetail[3]);
        // }
        //methods
        public void WalletRecharge(int rechargeAmount){
            Balance=Balance+rechargeAmount;
        }
        public void DeductBalance(int deductAmount){
            Balance=Balance-deductAmount;
        }

    }
