using System;

namespace Calculator
{
    public static class FactoryOneArgument
    {
        public static IOneArgument CreatCalculator(string calculator)
        {
            switch (calculator)
            {
                case "Sin":
                    return new Sin();
                case "Cos":
                    return new Cos();
                case "Tan":
                    return new Tan();
                case "Cot":
                    return new Cot();
                case "Sqrt":
                    return new Sqrt();
                case "Squaring":
                    return new Squaring();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}