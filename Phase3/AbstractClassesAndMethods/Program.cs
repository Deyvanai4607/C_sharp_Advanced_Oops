using System;
namespace AbstractClassesAndMethods;
class Program{
    public static void Main(string[] args)
    {
        Employee job1=new Syncfusion();
        job1.Name="Naruto";
        Console.WriteLine(job1.Display());
        Console.WriteLine(job1.Salary(30));

        Employee job2 = new Zoho();
        job2.Name = "Sasuke";
        Console.WriteLine(job2.Display());
        Console.WriteLine(job2.Salary(30));
    }
}
