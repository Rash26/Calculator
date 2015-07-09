using System;

namespace Calculator.ClassesTwoArguments
{
    /// <summary>
    /// Calculates power
    /// </summary>
    public class Power : ITwoArgument
    {
        public double Calculate(double argumentOne, double argumentTwo)
        {
            return Math.Pow(argumentOne,argumentTwo);
        }
    }
}
