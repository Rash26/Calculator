using System;

namespace Calculator.ClassesOneArguments
{
    /// <summary>
    /// Calculates cotangens
    /// </summary>
    public class Cot : IOneArgument
    {
        public double Calculate(double argument)
        {
            if (argument == 0 || argument == 180 || argument == 360)
            {
                throw new Exception("Нельзя вычислить");
            }

            return 1f/Math.Tan(argument*Math.PI/180);
        }
    }
}