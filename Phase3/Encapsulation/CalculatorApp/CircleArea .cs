using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace CalculatorApp
{
  public class CircleArea : Maths
  {

    //Field: protected radius
    protected double radius;
    //Property : public Radius, internal area
    public double Radius { get; set; }
    internal double area { get; set; }
    //Method : CalculateCircleArea = PI*radious2
    public double CalculateCircleArea()
    {
      double circleArea = PI * radius * radius;
      return circleArea;
    }
  }
}