using System;

namespace Calculator
{
    class Squaring : IOneArgument
    {
        public double Calculate(double x)
        {
            return x*x;
        }
    }
}