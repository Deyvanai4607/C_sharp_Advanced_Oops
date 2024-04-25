using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependancyInjection
{
    public class SVAccount:IAccount
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
    }
}