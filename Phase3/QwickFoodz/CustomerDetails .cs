using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class CustomerDetails : PersonalDetails, IBalance
    {
        //Field: _balance
        private int _balance;
        //static feild
        private static int s_customerID = 1000;
        //Properties: CustomerID, WalletBalance
        public string CustomerID { get; set; }
        public int WalletBalance { get { return _balance; } }
        //Constructor
        //WalletBalance	Name	FatherName	Gender	Mobile	DOB	MailID	Location
        public CustomerDetails(int walletBalance, string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID, string location) : base(name, fatherName, gender, mobile, dob, mailID, location)
        {
            s_customerID++;
            CustomerID = "CID" + s_customerID;
            _balance = walletBalance;
        }

        public CustomerDetails(string customerID, int walletBalance, string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID, string location) : base(name, fatherName, gender, mobile, dob, mailID, location)
        {

            CustomerID = customerID;
            s_customerID = int.Parse(customerID.Remove(0, 3));
            _balance = walletBalance;
        }

        //Methods: WalletRecharge, DeductBalance
        public void WalletRecharge(int rechargeAmount)
        {
            _balance = _balance + rechargeAmount;
        }

        public void DeductBalance(int deductAmount)
        {
            _balance = _balance - deductAmount;
        }






    }
}