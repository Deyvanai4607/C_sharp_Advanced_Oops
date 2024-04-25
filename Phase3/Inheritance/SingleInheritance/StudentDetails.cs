using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentID=1000;
        public string StudentID { get; set; }
        public int Standard { get; set; }
        public int Year { get; set; }
        public StudentDetails(int std,int year,string userID,string userName,string fatherName,long phoneNumber,Gender gender):base( userID,userName, fatherName, phoneNumber, gender){
            s_studentID++;
            StudentID="SID"+s_studentID;
            Standard=std;
            Year=year;
             
        }
    }
}