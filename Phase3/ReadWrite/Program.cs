using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace ReadWrite;
public class Program{
    public static void Main(string[] args)
    {
        StudentDetails student1 = new StudentDetails("devi","kaliyaperumal",34567987,Gender.female);
        StudentDetails student2 = new StudentDetails("nila","kaliyaperumal",345767987,Gender.female);
        StudentDetails student3 = new StudentDetails("dhivya","kaliyaperumal",345967987,Gender.female);
        StudentDetails student4 = new StudentDetails("bala","kaliyaperumal",345637987,Gender.male);
        StudentDetails student5 = new StudentDetails("ashok","kaliyaperumal",345676987,Gender.male);
        List<StudentDetails> studentList=new List<StudentDetails>();
        studentList.AddRange(new List<StudentDetails>(){student1,student2,student3,student4,student5});
        //folder creation
        if(!Directory.Exists("TestFolder")){
            System.Console.WriteLine("folder created...");
            Directory.CreateDirectory("TestFolder");
        }else{
            System.Console.WriteLine("Folder already exsist...");
        }
        //csv file creation
        if(!File.Exists("TestFolder/Data.csv")){
            System.Console.WriteLine("CSV file created ....");
            File.Create("TestFolder/Data.csv").Close();
        }else{
            System.Console.WriteLine("CSV file already exsist...");
        }
        //json file creation
        if(!File.Exists("TestFolder/Data1.json")){
            System.Console.WriteLine("JSON file created ....");
            File.Create("TestFolder/Data1.json").Close();
        }else{
            System.Console.WriteLine("JSON file already exsist...");
        }
        WriterToCsv(studentList);
        ReadCSV();
        //WriteJSON(studentList);

    }
    static void  WriterToCsv(List<StudentDetails> studentList){
        StreamWriter sw=new StreamWriter("TestFolder/Data.csv");
        foreach(StudentDetails student in studentList){
            string line=student.Name+","+student.FatherName+","+student.PhoneNumber+","+student.Gender;
            sw.WriteLine(line);
            //Console.WriteLine("writing file...");
        }
        sw.Close();        
    }
    static void ReadCSV(){
        List<StudentDetails> newList=new List<StudentDetails>();
        StreamReader sr=new StreamReader("TestFolder/Data.csv");
        string line=sr.ReadLine();
        while(line!=null){
            string[] values=line.Split(",");
            
                if(values[0]!=null){
                    StudentDetails studentData=new StudentDetails(values[0],values[1],long.Parse(values[2]),Enum.Parse<Gender>(values[3]));
                    newList.Add(studentData);
                }
            
            line=sr.ReadLine();
        }
        foreach(StudentDetails student in newList){
            System.Console.WriteLine($"Name : {student.Name}| Father Name : {student.FatherName}| Phone Number : {student.PhoneNumber}| Gender : {student.Gender}");
        }
        sr.Close();
    }
    //json file read and write
    // static void WriteJSON(List<StudentDetails> studentList){
    //     StreamWriter sw =new StreamWriter("TestFolder/Data1.json");
    //     var option=new JsonSerializerOptions{
    //         WriteIndented=true
    //     };
    //     string jsonData=JsonSerializer.Serialize (studentList,option);
    //     sw.WriteLine(jsonData);
    //     sw.Close();
        
    // }
    // static void ReadJSON(){
    //     List<StudentDetails> newList=JsonSerializer.Deserialize<List<StudentDetails>>(File.ReadAllText("TestFolder/Data1.json"));

    // }
}
