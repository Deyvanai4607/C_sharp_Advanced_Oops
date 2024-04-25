using System;
namespace OnlineMedicalStore;
public class Program{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        //calling default values
        //Operation.DefaultValues();
        FileHandling.ReadFromCsv();
        //calling main menu
        Operation.MainMenu();
        FileHandling.WriteCsv();
    }
}
