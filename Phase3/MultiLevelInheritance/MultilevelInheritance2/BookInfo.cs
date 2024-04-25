using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance2
{
    public class BookInfo:RackInfo
    {
        //Properties: BookID, BookName, AuthorName, Price
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }   
        public BookInfo(string bookID,string bookName,string authorName,int price,int rackNumber, int columnNumber,string departmentName,string degree):base(rackNumber,columnNumber, departmentName, degree){
              BookID=bookID;
              BookName=bookName;
              AuthorName=authorName;
              Price=price;
        }
        //Method: Display info
        public void Displayinfo(){
            Console.WriteLine("*****************Book information*******************");
            Console.WriteLine($"Book ID : {BookID}");
            Console.WriteLine($"Book Name : {BookName}");
            Console.WriteLine($"Author Name : {AuthorName}");
            Console.WriteLine($"Book Price : {Price}");
            Console.WriteLine($"Book RackNumber : {RackNumber}");
            Console.WriteLine($"Book ColumnNumber : {ColumnNumber}");
            Console.WriteLine($"Book DepartmentName : {DepartmentName}");
            Console.WriteLine($"Book Degree : {Degree}");
        }      
    }
}