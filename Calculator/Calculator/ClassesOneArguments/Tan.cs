using System;

namespace Calculator
{
    public class Tan : IOneArgument
    {
        public double Calculate(double x)
        {
            return Math.Tan(x * Math.PI / 180);
        }
    }
}