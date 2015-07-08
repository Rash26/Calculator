using System;

namespace Calculator.ClassesOneArguments
{
    public class Sqrt : IOneArgument
    {
        public double Calculate(double x)
        {
            return Math.Sqrt(x);
        }
    }
}