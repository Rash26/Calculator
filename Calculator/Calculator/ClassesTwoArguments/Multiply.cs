namespace Calculator.ClassesTwoArguments
{
    public class Multiply : ITwoArgument
    {
        public double Calculate(double x, double y)
        {
            return x * y;
        }
    }
}
