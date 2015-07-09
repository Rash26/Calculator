namespace Calculator.ClassesTwoArguments
{
    public class Added : ITwoArgument
    {
        public double Calculate(double argumentOne, double argumentTwo)
        {
            return argumentOne + argumentTwo;
        }
    }
}
