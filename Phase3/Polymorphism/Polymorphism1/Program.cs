using System;
namespace Polymorphism1;
public class Program{
    public static void Main(string[] args)
    {
        //Method with one argument and display the Square value of a given number.
        SquareValue(8);
        // Method with 2 arguments with same argument type and display result.
        SquareValue(2,5);
        // Method with 3 arguments with same argument type and display the result.
        SquareValue(3,6,9);
        // Method with 2 arguments with different argument type and display result.
        SquareValue(2,5.5);
        // Method with 3 arguments with different argument type and display the result.
        SquareValue(2,5.8,4);
    }
    public static void  SquareValue(int number){
           System.Console.WriteLine($" Square value of {number} : {number*number}");  
    }
    public static void  SquareValue(int number1,int number2){
           System.Console.WriteLine($" Square values of {number1} and {number2} : {number1*number1} , {number2*number2}");  
    }
    public static void  SquareValue(int number1,int number2,int number3){
           System.Console.WriteLine($" Square values of {number1} and {number2} and {number3} : {number1*number1} , {number2*number2} , {number3*number3}");  
    }
    public static void  SquareValue(int number1,double number2){
           System.Console.WriteLine($" Square values of {number1} and {number2} : {number1*number1} , {number2*number2}");  
    }
    public static void  SquareValue(int number1,double number2,int number3){
           System.Console.WriteLine($" Square values of {number1} and {number2} and {number3} : {number1*number1} , {number2*number2} , {number3*number3}");  
    }
}