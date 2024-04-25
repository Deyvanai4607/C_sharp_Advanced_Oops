using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass1
{
    public partial class EmployeeProps 
    {
        //EmployeeID,Name,Gender,DOB, Mobile
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Mobile { get; set; }
  
    }
}