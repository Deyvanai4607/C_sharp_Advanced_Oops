using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public enum Gender{Female,Male}
    public class PersonalDetails
    {
        //static id
        private static int s_userID=1000;
        //property
        public string UserID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long PhoneNumber { get; set; }
        public Gender Gender { get; set; }

        public PersonalDetails(string userName,string fatherName,long phoneNumber,Gender gender){
            s_userID++;
            UserID="UID"+s_userID;
            Name=userName;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            Gender=gender;
        }
         public PersonalDetails(string userID,string userName,string fatherName,long phoneNumber,Gender gender){
            
            UserID=userID;
            Name=userName;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            Gender=gender;
        }
    }
}