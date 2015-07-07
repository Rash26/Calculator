using System;

namespace Calculator
{
    class Sqrt : IOneArgument
    {
        public double Calculate(double x)
        {
            return Math.Sqrt(x);
        }
    }
}