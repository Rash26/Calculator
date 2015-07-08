using System;

namespace Calculator 
{
    public class Sin : IOneArgument
    {
        public double Calculate(double x)
        {
            return Math.Sin(x * Math.PI / 180);
        }
    }
}
