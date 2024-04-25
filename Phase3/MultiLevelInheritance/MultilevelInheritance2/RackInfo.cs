using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance2
{
    public class RackInfo:DepartmentDetails
    {
        //Properties: RackNumber, ColumnNumber
        //string departmentName,string degree
        public int RackNumber { get; set; }
        public int ColumnNumber { get; set; }
        public RackInfo(int rackNumber,int columnNumber,string departmentName,string degree):base( departmentName,degree){
            RackNumber=rackNumber;
            ColumnNumber=columnNumber;
        }
        
    }
}