using System;

namespace Calculator.ClassesOneArguments
{
    /// <summary>
    /// Calculates tangens
    /// </summary>
    public class Tan : IOneArgument
    {
        public double Calculate(double argument)
        {
            if (argument == 90 || argument == 270)
            {
                throw new Exception("Нельзя вычислить");
            }

            return Math.Tan(argument*Math.PI/180);
        }
    }
}