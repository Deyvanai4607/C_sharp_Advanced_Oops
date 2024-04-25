using System;
namespace MetroCardManagement;
public class Program{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        //calling default values 
        //Operation.DefaultValues();
        FileHandling.ReadFromCSV();
        //main menu calling
        Operation.MainMenu();
        FileHandling.WriteCSV();
        
    }
}
