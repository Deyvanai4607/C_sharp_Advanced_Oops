using System;
namespace ReadAndWrite;
class Programs{
    public static void Main(string[] args)
    {
        //Getting the inputs
        Console.Write("Enter your name : ");
        string name=Console.ReadLine();
        Console.Write("Enter your Father name : ");
        string fatherName=Console.ReadLine();
        //printing the result
        //concadination
        Console.WriteLine(name +" "+ fatherName);
        //placeholder
        Console.WriteLine("{0} {1}",name,fatherName);
        Console.WriteLine("{0} {1}",fatherName,name);
        Console.WriteLine("{1} {0}",name,fatherName);
        //Interpolation
        Console.WriteLine($"{name} {fatherName}");  //less runtime
        Console.ReadKey();
    }
}
