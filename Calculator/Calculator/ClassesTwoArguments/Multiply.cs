namespace Calculator.ClassesTwoArguments
{
    public class Multiply : ITwoArgument
    {
        public double Calculate(double argumentOne, double argumentTwo)
        {
            return argumentOne * argumentTwo;
        }
    }
}
