using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance1
{
    public class PersonalInfo
    {
        //Properties: Name, FatherName, Phone ,Mail, DOB, Gender
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }

        //Constructor to assign values
        public PersonalInfo(string name,string fatherName,long phone,string mail,DateTime dob,string gender){
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }
    }
}