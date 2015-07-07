using System;

namespace Calculator 
{
    class Sin : IOneArgument
    {
        public double Calculate(double x)
        {
            return Math.Sin(x * Math.PI / 180);
        }
    }
}
