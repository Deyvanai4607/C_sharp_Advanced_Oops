using System;
using MultilevelInheritance2;
namespace MultiLevelInheritance;
public class Program{
    public static void Main(string[] args)
    {
       
        BookInfo book1=new BookInfo("B1001","HTML","hgcujg",500,3, 4,"CS","MCA");
        book1.Displayinfo();
       
        BookInfo book2=new BookInfo("B1002","Java","sdgfjdm",480,4, 4,"CS","MCA");
        book2.Displayinfo();
       
        BookInfo book3=new BookInfo("B1003","C#","dfshg",650,5, 4,"CS","MCA");
        book3.Displayinfo();
    }
}