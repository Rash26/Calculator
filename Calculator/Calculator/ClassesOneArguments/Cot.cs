using System;

namespace Calculator.ClassesOneArguments
{
    public class Cot : IOneArgument
    {
        public double Calculate(double x)
        {
            if (x == 0 || x == 180 || x == 360)
            {
                throw new Exception("Нельзя вычислить");
            }
            else
            {
                return 1f / Math.Tan(x * Math.PI / 180);
            }
        }
    }
}