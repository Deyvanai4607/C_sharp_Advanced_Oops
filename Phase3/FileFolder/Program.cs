using System;
using System.IO;
namespace FileFolder;
public class Program{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\DeyvanaiKaliyaperuma\OneDrive - Syncfusion\Desktop\MyFolder" ;   
        string folderPath=path+"/devi";
        if(!Directory.Exists(folderPath)){
            Console.WriteLine("Folder created...");
            Directory.CreateDirectory(folderPath);
        }else{
            Console.WriteLine("Folder already exist...");            
        }
        string filePath=path+"/myFile.txt";
        if(!File.Exists(filePath)){
            Console.WriteLine("File created...");
            File.Create(filePath);
        }else{
            Console.WriteLine("File already exist");
            
        }
        System.Console.WriteLine("Select\n1.Create Folder\n2.Create File\n3.Delete Folder\n4.Delete File");
        int option=int.Parse(Console.ReadLine());
        switch(option){
            case 1:{
                System.Console.WriteLine("Enter folder name you want to create : ");
                string createFolder=path+"/"+Console.ReadLine();
                if(!Directory.Exists(createFolder)){
                    System.Console.WriteLine("Folder created...");
                    Directory.CreateDirectory(createFolder);
                }else{
                    System.Console.WriteLine("Folder already exsist...");
                }
                
                break;
            }
            case 2:{
                System.Console.WriteLine("Enter file name and extention you want to create : ");
                string createFile=path+"/"+Console.ReadLine();
                if(!File.Exists(createFile)){
                    System.Console.WriteLine("File created...");
                    File.Create(createFile);
                }else{
                    System.Console.WriteLine("File already exsist...");
                }
                break;
            }
            case 3:{
                foreach(string deleteFolderPath in Directory.GetDirectories(path)){
                    System.Console.WriteLine(deleteFolderPath);
                }
                System.Console.WriteLine("Enter folder name which you want to delete : ");
                string deleteFolder=Console.ReadLine();
                foreach(string deleteFolderPath in Directory.GetDirectories(path)){
                    if(deleteFolderPath.Equals(deleteFolder)){
                        System.Console.WriteLine("Folder deleted...");
                        Directory.Delete(deleteFolderPath);
                    }
                }
                break;
            }
            case 4:{
                foreach(string deleteFilePath in Directory.GetFiles(path)){
                    System.Console.WriteLine(deleteFilePath);
                }
                System.Console.WriteLine("Enter the file name and extention which you want to delete : ");
                string deleteFile=Console.ReadLine();
                foreach(string deleteFilePath in Directory.GetFiles(path)){
                    if(deleteFilePath.Contains(deleteFile)){
                        System.Console.WriteLine("File deleted...");
                        File.Delete(deleteFilePath);
                    }
                }
                break;
            }
        }
        
    }
}