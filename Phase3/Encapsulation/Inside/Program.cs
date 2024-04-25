using System;
namespace Inside;
public class Program{
    public static void Main(string[] args)
    {
        First first = new First();
        Console.WriteLine(first.PrivateOut);
        Console.WriteLine(first.PublicNumber);

        Second second=new Second();
        Console.WriteLine(second.ProtectedNumberOut);
        Console.WriteLine(second.ProtectedInternalOut);
    }
}
