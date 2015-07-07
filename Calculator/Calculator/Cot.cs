using System;

namespace Calculator
{
    class Cot : IOneArgument
    {
        public double Calculate(double x)
        {
            return 1f / Math.Tan(x * Math.PI / 180);
        }
    }
}