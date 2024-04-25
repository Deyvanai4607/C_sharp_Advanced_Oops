using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeDetails
{
    public class DepartmentDetails
    {
        /*a.	DepartmentID – (AutoIncrement - DID101)
            b.	DepartmentName
            c.	NumberOfSeats
        */
        //static field
        private static int s_departmentID=100;
        //properties
        public string DepartmentID { get; }    //read only
        public string DepartmentName { get; set; }
        public int NumberOfSeats { get; set; }
        //constructor
        public DepartmentDetails(string depName,int numberOfSeat){
            //auto increament
            s_departmentID++;
            DepartmentID="DID"+s_departmentID;
            DepartmentName=depName;
            NumberOfSeats=numberOfSeat;
        }

    }
}