using System;

namespace Calculator.ClassesTwoArguments
{
    public class Power : ITwoArgument
    {
        public double Calculate(double x, double y)
        {
            return Math.Pow(x,y);
        }
    }
}
