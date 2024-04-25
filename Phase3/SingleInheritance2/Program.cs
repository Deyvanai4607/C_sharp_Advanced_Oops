using System;
namespace SingleInheritance2;
public class Program{
    public static void Main(string[] args)
    {
        AccountInfo customer1 = new AccountInfo("chennai", "IFSC0001", 5000, "Devi", "Kaliyaperumal", 8767456777, "devi@gmail.com", new DateTime(2005, 11, 11), "female");
        customer1.ShowAccountInfo();
        customer1.Deposit();
        customer1.Withdraw();
        customer1.ShowBalance();
        Console.WriteLine("**********************************************");
        AccountInfo customer2= new AccountInfo("chennai", "IFSC0002", 5000, "Nila", "Kaliyaperumal", 8767456797, "nila@gmail.com", new DateTime(2005, 11, 10), "female");
        customer2.ShowAccountInfo();
        customer2.Deposit();
        customer2.Withdraw();
        customer2.ShowBalance();
         Console.WriteLine("**********************************************");
        AccountInfo customer3 = new AccountInfo("chennai", "IFSC0003", 5000, "Dhivya", "Kaliyaperumal", 8767456757, "dhivya@gmail.com", new DateTime(2005, 11, 09), "female");
        customer3.ShowAccountInfo();
        customer3.Deposit();
        customer3.Withdraw();
        customer3.ShowBalance();
         Console.WriteLine("**********************************************");
    }
}
