using System;
namespace MultipleInheritance1;
public class Program{
    public static void Main(string[] args)
    {
        RegisterPerson register=new RegisterPerson("devi","female",new DateTime(2001,03,07),"3456789","23456789",MaritalDetails.single,"kaliyaperumal","Dhanalakshmi","14,dfghjk,dfghjk,dfghj",1);
        register.ShowInfo();
        System.Console.WriteLine("******************Person Info****************");
        Personalnfo person=new Personalnfo("devi","female",new DateTime(2001,03,07),"3456789","23456789",MaritalDetails.single );
        person.ShowInfo();

    }
}