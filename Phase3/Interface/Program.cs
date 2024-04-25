using System;
namespace Interface;
public class Program{
    public static void Main(string[] args)
    {
        Square number=new Square(); //class variable as object
        number.Number=20;
        Console.WriteLine(number.Calculate());
        Circle number2=new Circle();
        number2.Number=30;
        Console.WriteLine(number2.Calculate());
    }
}