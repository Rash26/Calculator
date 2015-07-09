namespace Calculator.ClassesOneArguments
{
    /// <summary>
    /// Calculates squaring
    /// </summary>
    public class Squaring : IOneArgument
    {
        public double Calculate(double argument)
        {
            return argument * argument;
        }
    }
}