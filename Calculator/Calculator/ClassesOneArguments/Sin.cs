using System;

namespace Calculator.ClassesOneArguments 
{
    public class Sin : IOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument * Math.PI / 180);
        }
    }
}
