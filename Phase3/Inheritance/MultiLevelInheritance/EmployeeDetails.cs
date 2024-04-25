using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmployeeDetails:StudentDetails
    {
        private static int s_employeeID=3000;
        public string EmployeeID { get; set; }
        public string Designation { get; set; }
        public EmployeeDetails(string studentID,int std,int year,string userID,string userName,string fatherName,long phoneNumber,Gender gender,string designation):base(studentID,std,year, userID,userName, fatherName, phoneNumber, gender){
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Designation=designation;
        }
        
    }
}