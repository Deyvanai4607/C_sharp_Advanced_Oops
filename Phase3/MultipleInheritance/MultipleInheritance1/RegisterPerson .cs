using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance1
{
    public class RegisterPerson : Personalnfo,IShowData,IFamilyInfo
    {
        //Properties: RegistrationNumber(Auto), DateOfRegistration,
        private static int s_registrationNumber=1000;
        public string RegistrationNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSiblings { get; set; }
       public RegisterPerson(string name, string gender, DateTime dob, string phone,string mobile,MaritalDetails maritalDetails,string fatherName,string motherName,string houseAddress,int noOfSiblings):base(  name,   gender,   dob,   phone,  mobile,    maritalDetails){
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            Mobile=mobile;
            MaritalDetails=maritalDetails;
            FatherName=fatherName;
            MotherName=motherName;
            HouseAddress=houseAddress;
            NoOfSiblings=noOfSiblings;

        }
        
        public void ShowInfo(){
             System.Console.WriteLine($"Name : {Name}");
             System.Console.WriteLine($"Gender : {Gender}");
             System.Console.WriteLine($"DOB : {DOB}");
             System.Console.WriteLine($"phone : {Phone}");
             System.Console.WriteLine($"mobile : {Mobile}");
             System.Console.WriteLine($"Marital Details : {MaritalDetails}");
             System.Console.WriteLine($"Father Name : {FatherName}");
             System.Console.WriteLine($"Mother Name : {MotherName}");
             System.Console.WriteLine($"House Address : {HouseAddress}");
             System.Console.WriteLine($"No Of Siblings : {NoOfSiblings}");
        }
        
        
    }
}