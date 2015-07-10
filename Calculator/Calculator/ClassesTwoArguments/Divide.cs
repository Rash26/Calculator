using System;
using System.Windows.Forms;

namespace Calculator.ClassesTwoArguments
{
    /// <summary>
    /// Calculates divide
    /// </summary>
    public class Divide : ITwoArgument
    {
        public double Calculate(double argumentOne, double argumentTwo)
        {
                return argumentOne / argumentTwo;
        }
    }
}
