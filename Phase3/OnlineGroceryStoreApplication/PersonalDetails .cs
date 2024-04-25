using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public enum Gender{Select, Male, Female, Transgender}
    public class PersonalDetails 
    {
        
        //properties
        public string Name { get; set;  }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        
        
        public string MailID { get; set; }
        //constructor
       
        //Properties: Name, FatherName, Gender, Mobile, DOB, MailID
        public PersonalDetails(string name,string fatherName, Gender gender,long mobile,DateTime dob,string mailID){
            
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Mobile=mobile;
            MailID=mailID;
        }
    }
}