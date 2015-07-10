using System;
using System.Windows.Forms;

namespace Calculator.ClassesOneArguments
{
    /// <summary>
    /// Calculates cosinus
    /// </summary>
    public class Cos : IOneArgument
    {
        public double Calculate(double argument)
        {
                return Math.Cos(argument*Math.PI/180);
        }
    }
}
