using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class StudentInfo:PersonalInfo
    {
        //Propeties: RegisterNumber, Standard, Branch, AcadamicYear
        public int RegisterNumber { get; set; }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public int AcadamicYear { get; set; } 

        //constructor
        public StudentInfo(int registerNumber,int standard,string branch,int acadamicYear,string name,string fatherName,long phone,string mail,DateTime dob,string gender):base( name, fatherName, phone, mail, dob, gender){
          RegisterNumber=registerNumber; 
          Standard=standard; 
          Branch=branch;
          AcadamicYear=acadamicYear;
        }
        //Method:  ShowStudentInfo
        public void ShowStudentInfo(){
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"fatherName : {FatherName}");
            Console.WriteLine($"phone : {Phone}");
            Console.WriteLine($"mail : {Mail}");
            Console.WriteLine($"dob : {DOB}");
            Console.WriteLine($"gender : {Gender}");
            Console.WriteLine($"RegisterNumber : {RegisterNumber}");
            Console.WriteLine($"Standard : {Standard}");
            Console.WriteLine($"Branch : {Branch}");
            Console.WriteLine($"AcadamicYear : {AcadamicYear}");
            
        }

    }
}