using System;

namespace Calculator.ClassesTwoArguments
{
    public class Divide : ITwoArgument
    {
        public double Calculate(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                throw new Exception("Нельзя делить на ноль");
            }
            
        }
    }
}
