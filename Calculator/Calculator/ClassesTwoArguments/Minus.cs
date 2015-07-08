namespace Calculator
{
    public class Minus : ITwoArgument
    {
        public double Calculate(double x, double y)
        {
            return x - y;
        }
    }
}
