namespace Calculator.ClassesOneArguments
{
    public class Squaring : IOneArgument
    {
        public double Calculate(double argument)
        {
            return argument * argument;
        }
    }
}