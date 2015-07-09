using System;

namespace Calculator.ClassesOneArguments
{
    public class Sqrt : IOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Sqrt(argument);
        }
    }
}