using System;

namespace Calculator.ClassesTwoArguments
{
    public class Divide : ITwoArgument
    {
        public double Calculate(double argumentOne, double argumentTwo)
        {
            if (argumentTwo != 0)
            {
                return argumentOne / argumentTwo;
            }
            else
            {
                throw new Exception("Нельзя делить на ноль");
            }
            
        }
    }
}
