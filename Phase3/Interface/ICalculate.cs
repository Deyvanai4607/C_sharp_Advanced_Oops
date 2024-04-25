using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICalculate
    {
        //no feilds and constructor
        //property
        int Number { get; set; } //declaration only
        int Calculate();// Methods - declaration
        //fully abstraction - no definition
        
    }
}