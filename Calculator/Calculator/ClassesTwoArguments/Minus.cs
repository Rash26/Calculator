namespace Calculator.ClassesTwoArguments
{
    public class Minus : ITwoArgument
    {
        public double Calculate(double argumentOne, double argumentTwo)
        {
            return argumentOne - argumentTwo;
        }
    }
}
