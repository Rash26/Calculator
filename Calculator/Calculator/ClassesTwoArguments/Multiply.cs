namespace Calculator.ClassesTwoArguments
{
    /// <summary>
    /// Calculates multiply
    /// </summary>
    public class Multiply : ITwoArgument
    {
        public double Calculate(double argumentOne, double argumentTwo)
        {
            return argumentOne * argumentTwo;
        }
    }
}
