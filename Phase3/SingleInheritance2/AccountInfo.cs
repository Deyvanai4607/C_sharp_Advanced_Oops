using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance2
{
    public class AccountInfo:PersonalInfo
    {
        private static int s_accountNumber=1000;
        //Properties: AccountNumber, BranchName, IFSCCode, Balance
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public int Balance { get; set; } 

        //constructor
        public AccountInfo( string branchName,string iFSCCode,int balance,string name,string fatherName,long phone,string mail,DateTime dob,string gender):base( name, fatherName, phone, mail, dob, gender){
          s_accountNumber++;  
          AccountNumber="ACN"+s_accountNumber; 
          BranchName=branchName; 
          IFSCCode=iFSCCode;
          Balance=balance;
        }
         //Methods: ShowAccountInfo, Deposit , Withdraw, ShowBalance.
        public void ShowAccountInfo(){
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"fatherName : {FatherName}");
            Console.WriteLine($"phone : {Phone}");
            Console.WriteLine($"mail : {Mail}");
            Console.WriteLine($"dob : {DOB}");
            Console.WriteLine($"gender : {Gender}");
            Console.WriteLine($"AccountNumber : {AccountNumber}");
            Console.WriteLine($"BranchName : {BranchName}");
            Console.WriteLine($"IFSCCode : {IFSCCode}");
            Console.WriteLine($"Balance : {Balance}");
            
        }
        public void Deposit(){
            Console.Write("Enter Deposit Amount : ");
            int dep=int.Parse(Console.ReadLine());
            Balance=Balance+dep;
            Console.WriteLine("Deposit Successfully Done");
        }
        public void Withdraw(){
            Console.Write("Enter Withdraw Amount : ");
            int wed=int.Parse(Console.ReadLine());
            Balance=Balance-wed;
            Console.WriteLine("Withdraw Successfully Done");
        }
        public void ShowBalance(){
            Console.WriteLine($"Your Current Balance is :{Balance}");
        }
       
    }
}