using System;

namespace Calculator.ClassesOneArguments
{
    public class Cot : IOneArgument
    {
        public double Calculate(double argument)
        {
            if (argument == 0 || argument == 180 || argument == 360)
            {
                throw new Exception("Нельзя вычислить");
            }
            else
            {
                return 1f / Math.Tan(argument * Math.PI / 180);
            }
        }
    }
}