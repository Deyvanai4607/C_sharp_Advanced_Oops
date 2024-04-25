using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance2
{
    public class DepartmentDetails
    {
        //Properties: DepartmentName, Degree
        public string DepartmentName { get; set; }
        public string Degree { get; set; }       
        public DepartmentDetails(string departmentName,string degree){
            DepartmentName=departmentName;
            Degree=degree;
        }     
        
    }
}