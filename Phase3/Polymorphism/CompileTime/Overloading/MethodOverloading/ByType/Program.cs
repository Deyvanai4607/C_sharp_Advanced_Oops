using System;
namespace ByType;
public class Program{
    public static void Main(string[] args)
    {
        //add methodto an integer
        int result=Add(1,5);
        double result1=Add(1,5.0);
        string result2=Add("aaaaa","bbbbbbb");
    }
    public static int Add(int A,int B){
        return A+B;
    }
    public static double Add(double A,double B){
        return A+B;
    }
    public static String Add(String A,String B){
        return A+B;
    }
}