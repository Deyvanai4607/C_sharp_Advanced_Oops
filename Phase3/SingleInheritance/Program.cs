using System;
namespace SingleInheritance;
public class Program{
    public static void Main(string[] args)
    {
        StudentInfo student1 = new StudentInfo(1001, 10, "A", 2024, "Devi", "Kaliyaperumal", 8767456777, "devi@gmail.com", new DateTime(2005, 11, 11), "female");
        student1.ShowStudentInfo();
    }
}