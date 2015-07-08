using System;

namespace Calculator.ClassesOneArguments
{
    public class Cos : IOneArgument
    {
     public double Calculate(double x)
        {
            return Math.Cos(x * Math.PI / 180);
        }
    }
}
