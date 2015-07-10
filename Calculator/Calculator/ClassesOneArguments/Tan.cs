using System;

namespace Calculator.ClassesOneArguments
{
    /// <summary>
    /// Calculates tangens
    /// </summary>
    public class Tan : IOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument*Math.PI/180);
        }
    }
}