using System;

namespace Calculator.ClassesOneArguments 
{
    public class Sin : IOneArgument
    {
        public double Calculate(double x)
        {
            return Math.Sin(x * Math.PI / 180);
        }
    }
}
