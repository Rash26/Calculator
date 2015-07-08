using System;

namespace Calculator
{
    public class Sqrt : IOneArgument
    {
        public double Calculate(double x)
        {
            return Math.Sqrt(x);
        }
    }
}