using System;

namespace Calculator
{
    class Cos : OneArgument
    {
     public double calculate(double x)
        {
            return Math.Cos(x * Math.PI / 180);
        }
    }
}
