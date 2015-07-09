using System;

namespace Calculator.ClassesTwoArguments
{
    public class Power : ITwoArgument
    {
        public double Calculate(double argumentOne, double argumentTwo)
        {
            return Math.Pow(argumentOne,argumentTwo);
        }
    }
}
