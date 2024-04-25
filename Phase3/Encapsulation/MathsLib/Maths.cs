using System.Net.NetworkInformation;

namespace MathsLib;

public class Maths
{
    //Field : protected internal PI =3.14; internal g= 9.8
    protected internal double PI=3.14;
    
    internal double g=9.8;
    //Method: CalculateWeight = Mass (user input) * g;
    public double CalculateWeight(double Mass){
       double Weight=Mass*g;
       return Weight;
    }

}
