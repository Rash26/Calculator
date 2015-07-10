using System;

namespace Calculator.ClassesOneArguments
{
    /// <summary>
    /// Calculates cotangens
    /// </summary>
    public class Cot : IOneArgument
    {
        public double Calculate(double argument)
        {
                return 1f / Math.Tan(argument * Math.PI / 180);
        }
    }
}