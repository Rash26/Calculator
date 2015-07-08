using System;

namespace Calculator
{
    public class Squaring : IOneArgument
    {
        public double Calculate(double x)
        {
            return x*x;
        }
    }
}