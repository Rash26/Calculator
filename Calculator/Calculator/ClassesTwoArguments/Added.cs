namespace Calculator.ClassesTwoArguments
{
    /// <summary>
    /// Calculates added
    /// </summary>
    public class Added : ITwoArgument
    {
        public double Calculate(double argumentOne, double argumentTwo)
        {
            return argumentOne + argumentTwo;
        }
    }
}
