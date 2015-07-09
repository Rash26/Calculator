namespace Calculator.ClassesTwoArguments
{
    /// <summary>
    /// Calculates minus
    /// </summary>
    public class Minus : ITwoArgument
    {
        public double Calculate(double argumentOne, double argumentTwo)
        {
            return argumentOne - argumentTwo;
        }
    }
}
