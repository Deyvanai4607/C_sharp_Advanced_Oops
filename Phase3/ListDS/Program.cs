using System;
using System.Collections.Generic;
namespace ListDS;
public class Program{
    public static void Main(string[] args)
    {
        CustomList<int> list=new CustomList<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);
        CustomList<int> list2=new CustomList<int>();
        list2.Add(60);
        list2.Add(70);
        list2.Add(90);
        list.AddRange(list2);

        bool result1=list.Contains(40);
        bool result2=list.Contains(100);

        int res=list.IndexOff(30);

        list.Insert(3,100);

        list.RemoveAt(3);

        list.Remove(40);
        foreach(int data in list){
            Console.WriteLine(data);
        }
        Console.WriteLine("##############Reverse List############### ");
        list.Reverse();
        foreach(int data in list){
            Console.WriteLine(data);
        }

        CustomList<int> newList=new CustomList<int>();
        newList.Add(101);
        newList.Add(102);

        Console.WriteLine("##############Insert Range############### ");
        list.InsertRange(3,newList);
        foreach(int data in list){
            Console.WriteLine(data);
        }

        Console.WriteLine("##############Sort############### ");
        list.Sort();
        foreach(int data in list){
            Console.WriteLine(data);
        }


    }
}