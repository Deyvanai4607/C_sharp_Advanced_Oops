using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// this is used to store personal details
    /// </summary>
    public class PersonalDetails 
    {
        /*Properties:
        •	UserName
        •	Phone Number
        */
        
         public string UserName { get; set; }
         public long PhoneNumber { get; set; }    
         //Constructor
         /// <summary>
         /// this is used to store personal details
         /// </summary>
         /// <param name="userName"></param>
         /// <param name="phoneNumber"></param>
         public PersonalDetails(string userName,long phoneNumber){
            UserName=userName;
            PhoneNumber=phoneNumber;
         }
        
    }
}