namespace Calculator.ClassesOneArguments
{
    public class Squaring : IOneArgument
    {
        public double Calculate(double x)
        {
            return x*x;
        }
    }
}