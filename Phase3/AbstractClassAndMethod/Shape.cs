using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassAndMethod
{
    public abstract class Shape
    {
        //Abstract Properties: Area, Volume
        public abstract double Area { get; set; }
        public abstract double Volume { get; set; }

        //Non abstract properties: Radius, Height, Width, Page - a
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double a { get; set; }
        //Abstract methods: CalculateArea, CalculateVolume
        public  abstract double CalculateArea();
        public abstract double CalculateVolume();
    }
}