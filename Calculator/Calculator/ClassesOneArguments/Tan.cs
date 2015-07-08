using System;

namespace Calculator.ClassesOneArguments
{
    public class Tan : IOneArgument
    {
        public double Calculate(double x)
        {
            if (x == 90 || x == 270)
            {
                throw new Exception("Нельзя вычислить");
            }
            else
            {   
                return Math.Tan(x * Math.PI / 180);
            }
        }
    }
}