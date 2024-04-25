using System;
using System.IO;
namespace ReadWriteText;
public class Program{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder")){
            Directory.CreateDirectory("TestFolder");
            Console.WriteLine("folder created");
        }else{
            System.Console.WriteLine("folder already exist");
        }
        if(!File.Exists("TestFolder/Data.txt")){
            File.Create("TestFolder/Data.txt").Close();
            System.Console.WriteLine("file created");
        }else{
            System.Console.WriteLine("file already exist");
        }
        ReadTextFile();
        WriteTextFile();
    }
    static void ReadTextFile(){
        StreamReader sr=new StreamReader("TestFolder/Data.txt");
        string line =sr.ReadLine();
        while(line!=null){
            System.Console.WriteLine(line);
            line=sr.ReadLine();
        }
        sr.Close();
    }
    static void WriteTextFile(){
        string[] contents=File.ReadAllLines("TestFolder/Data.txt");
        StreamWriter sw=new StreamWriter("TestFolder/Data.txt");
        string old="";
        foreach(string line in contents){
            old=old+line+"\n";
        }
        System.Console.WriteLine("enter the line you want to add : ");
        string newLine=Console.ReadLine();
        old=old+newLine;
        sw.WriteLine(old);
        sw.Close();

    }
} 
