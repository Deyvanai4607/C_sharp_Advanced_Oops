using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance1
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
        
        
        //Method: GetStudentInfo, ShowInfo
        public void GetStudentInfo(){
            Console.Write("Enter student name : ");
            Name=Console.ReadLine();
            Console.Write("Enter student FatherName : ");
            FatherName=Console.ReadLine();
            Console.Write("Enter student Phone number : ");
            Phone=long.Parse(Console.ReadLine());
            Console.Write("Enter student Mail : ");
            Mail=Console.ReadLine();
            Console.Write("Enter student DOB (dd/MM/yyyy): ");
            DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Enter student Gender : ");
            Gender=Console.ReadLine();
            Console.Write("Enter student RegisterNumber : ");
            RegisterNumber=int.Parse(Console.ReadLine());
            Console.Write("Enter student Standard : ");
            Standard=int.Parse(Console.ReadLine());
            Console.Write("Enter student Branch : ");
            Branch = Console.ReadLine();
            Console.Write("Enter student AcadamicYear : ");
            AcadamicYear = int.Parse(Console.ReadLine());

        }
        public void ShowInfo(){
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