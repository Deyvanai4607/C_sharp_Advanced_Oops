using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeDetails
{
    public enum Gender{Select, Male, Female, Transgender}
    public class StudentDetails
    {
        /*a.	StudentName
            b.	FatherName
            c.	DOB
            d.	Gender – Enum (Select, Male, Female, Transgender)
            e.	Physics
            f.	Chemistry
            g.	Maths

        */
        //Static feild
        private static int s_studentID=3000;
        //properties
        public string StudentID { get;   } //READ ONLY
         public string StudentName { get; set; }   
         public string FatherName { get; set; }
         public DateTime DOB { get; set; }
         public Gender Gender { get; set; }
         public int Physics { get; set; }
         public int Chemistry { get; set; }
         public int Maths { get; set; }
         //constructor
         public StudentDetails(string studentName,string fatherName,DateTime dob, Gender gender,int physics,int chemistry,int maths){
             //auto increament
             s_studentID++;
             StudentID="SF"+s_studentID;
             StudentName=studentName;
             FatherName=fatherName;
             DOB=dob;
             Gender=gender;
             Physics=physics;
             Chemistry=chemistry;
             Maths=maths;
         }
         //methods
         public double Average(){
            int total=Physics+Chemistry+Maths;
            double average =(double)total/3;
            return average ;
         } 
         public bool CheckEligibility(double cutOff){
            if(Average()>=cutOff){
                return true;
            } 
            return false;
            
         } 

    }
}