using System;

namespace Calculator
{
    class Cos : IOneArgument
    {
     public double Calculate(double x)
        {
            return Math.Cos(x * Math.PI / 180);
        }
    }
}
