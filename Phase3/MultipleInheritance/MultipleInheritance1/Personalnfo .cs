using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance1
{
    public enum MaritalDetails{Married,single}
    public class Personalnfo :IShowData
    {
        //Properties: Name, Gender,DOB, phone, mobile, Marital details – Married/single
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public MaritalDetails MaritalDetails { get; set; }
        //constructor
        public Personalnfo(string name, string gender, DateTime dob, string phone,string mobile,MaritalDetails maritalDetails){
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            Mobile=mobile;
            MaritalDetails=maritalDetails;

        }
        public void ShowInfo(){
             System.Console.WriteLine($"Name : {Name}");
             System.Console.WriteLine($"Gender : {Gender}");
             System.Console.WriteLine($"DOB : {DOB}");
             System.Console.WriteLine($"phone : {Phone}");
             System.Console.WriteLine($"mobile : {Mobile}");
             System.Console.WriteLine($"MaritalDetails : {MaritalDetails}");
        }
    }
}