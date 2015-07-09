using System;

namespace Calculator.ClassesOneArguments
{
    public class Tan : IOneArgument
    {
        public double Calculate(double argument)
        {
            if (argument == 90 || argument == 270)
            {
                throw new Exception("Нельзя вычислить");
            }
            else
            {   
                return Math.Tan(argument * Math.PI / 180);
            }
        }
    }
}