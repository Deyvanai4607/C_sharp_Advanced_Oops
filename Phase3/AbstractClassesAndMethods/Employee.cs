using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public abstract class Employee //abstract class
    {
        //Abstract class  - partial abstraction
        //It has feils, properties, method, constructor, destructor, indexers, events
        //can have both abstract declaration and normal definitions
        //can only use with an inherited class
        //not support multiple inheritance
        //It can't be static class

        protected string _name;//normal feild
        public abstract string Name { get; set; }//abstract property
        public double Amount { get; set; }//Normal property
        public string Display()//normal method
        {
            return _name;
        }
        public abstract double Salary(int dates);//abstract method-only declaration
    }
}