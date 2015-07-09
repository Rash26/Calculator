using System;

namespace Calculator.ClassesOneArguments
{
    public class Cos : IOneArgument
    {
     public double Calculate(double argument)
        {
            return Math.Cos(argument * Math.PI / 180);
        }
    }
}
