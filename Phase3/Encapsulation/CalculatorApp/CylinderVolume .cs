using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CylinderVolume:CircleArea
    {
         
        //Field: private height
        private double height;
        //Property :  public Height, internal volume
        public double Height { get; set; }
        internal double volume { get; set; }
        //Method : CalculateVolume = CalculateCircleArea *height
        public double CalculateVolume(){
            double volume=CalculateCircleArea()*height;
            return volume;
        }
    }
}