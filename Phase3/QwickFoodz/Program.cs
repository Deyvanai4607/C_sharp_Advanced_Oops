using System;
namespace QwickFoodz;
public class Program
{
    public static void Main(string[] args)
    {
        //calling create method
        FileHandling.Create();

        //calling default values
        //Operation.DefaultValues();

        //calling read from csv metho
        FileHandling.ReadFromCSV();

        //main menu calling
        Operation.MainMenu();

        //calling write csv method
        FileHandling.WrteCSV();
    }
}
