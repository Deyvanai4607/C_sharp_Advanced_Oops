using System;
using AbstractClassAndMethod;
namespace AbstractClassAndMethods;
public class Program{
    public static void Main(string[] args)
    {
        Cylinders cylinders=new Cylinders(4,7);
        Cubes cubes=new Cubes(5);

        System.Console.WriteLine($"Cylinder Area is : {cylinders.CalculateArea()}");
        System.Console.WriteLine($"Cylinder Volume is : {cylinders.CalculateVolume()}");

        System.Console.WriteLine($"Cubes Area is : {cubes.CalculateArea()}");
        System.Console.WriteLine($"Cubes Volume is : {cubes.CalculateVolume()}");
    }
}
