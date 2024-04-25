 using System;
 namespace ByArgument;
 public class Program{
    public static void Main(string[] args)
    {
        Add(4,5,7);
        Add(2,1);
    }
    public static void Add(int a,int b,int c){
        Console.WriteLine(a+b+c);
    }
    public static void Add(int a,int b ){
        Console.WriteLine(a+b);
    }
 }