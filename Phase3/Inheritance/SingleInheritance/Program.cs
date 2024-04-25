using System;
namespace SingleInheritance;
class Program{
    public static void Main(string[] args)
    {
        PersonalDetails user=new PersonalDetails("devi","Kaliyaperumal",5895354366,Gender.Female);
        Console.WriteLine($"User Id : {user.UserID}\nUser Name : {user.Name}\nUser Father Name : {user.FatherName}\nUser Phone Number : {user.PhoneNumber}\nUser Gender : {user.Gender}");
        StudentDetails student=new StudentDetails(1,2024,user.UserID, user.Name,user.FatherName,user.PhoneNumber,user.Gender  );
    }
}