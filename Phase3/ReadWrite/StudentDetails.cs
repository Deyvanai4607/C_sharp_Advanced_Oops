using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadWrite
{
    public enum Gender{male,female,transgender}
    public class StudentDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public StudentDetails(string name,string fatherName,long phone,Gender gender){
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phone;
            Gender=gender;
        }
        
        
        
        
        
        
        
        
    }
}