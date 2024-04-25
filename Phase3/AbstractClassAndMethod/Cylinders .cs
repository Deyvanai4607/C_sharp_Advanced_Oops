using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassAndMethod
{
    public class Cylinders : Shape
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }
        //Overridden methods: CalculateArea - 2 π r(r+h) , CalculateVolume π r2 h

        public Cylinders(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }
        public override double CalculateArea()
        {
            Area = 2 * Math.PI * Radius * (Radius + Height);
            return Area;
        }
        public override double CalculateVolume()
        {
            Volume = Math.PI * Radius * Radius * Height;
            return Volume;
        }
    }
}