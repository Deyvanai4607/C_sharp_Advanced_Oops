using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class CustomerDetails:PersonalDetails 
    {
        private static int s_customerID=4000;
        public string CustomerID { get; set; }
        public int Balance { get; set; }
        public CustomerDetails(int balance,string userID,string userName,string fatherName,long phoneNumber,Gender gender):base( userID, userName, fatherName, phoneNumber, gender){
            s_customerID++;
            CustomerID="CID"+s_customerID;
            Balance=balance;
            UserID=userID;
            Name=userName;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            Gender=gender;
        }
    }
}