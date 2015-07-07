using System;

namespace Calculator 
{
    class Sin : OneArgument
    {
        public double calculate(double x)
        {
            return Math.Sin(x * Math.PI / 180);
        }
    }
}
