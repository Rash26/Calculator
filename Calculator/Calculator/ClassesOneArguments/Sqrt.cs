using System;

namespace Calculator.ClassesOneArguments
{
    /// <summary>
    /// Calculates sqrt
    /// </summary>
    public class Sqrt : IOneArgument
    {
        public double Calculate(double argument)
        {
                return Math.Sqrt(argument);
        }
    }
}