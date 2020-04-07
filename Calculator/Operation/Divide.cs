using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operation
{
    public class Divide : ICalc
    {
        public double DoMath(double a, double b)
        {
            return a / b;
        }
    }
}
