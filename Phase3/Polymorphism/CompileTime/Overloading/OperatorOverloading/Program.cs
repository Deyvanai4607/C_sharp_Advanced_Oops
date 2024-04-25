using System;
namespace OperatorOverloading;
public class Program{
    public static void Main(string[] args)
    {
        Box box1=new Box(1.2,3.2,4.2);
        Box box2=new Box(10.2,13.2,24.2);
        Console.WriteLine(box1.CalculateVolume());
        Console.WriteLine(box2.CalculateVolume());
        Box box3=Box.Add(box1,box2);
        Box box4= box1+box2;
    }
}
