using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassAndMethod
{
    public class Cubes:Shape 
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }
        //Overridden methods: CalculateArea -  6a2 , CalculateVolume - a3
        public Cubes(double page){
            a=page;
        }
        public override double CalculateArea(){
            Area=6*a*a;
            return Area;
        }

        public override double CalculateVolume(){
            Volume=a*a*a;
            return Volume;
        }
    }
}