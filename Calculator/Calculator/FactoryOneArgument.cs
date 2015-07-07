using System;

namespace Calculator
{
    public static class FactoryOneArgument
    {
        public static OneArgument CreatCalculator(string calculator)
        {
    switch (calculator)
            {
                case "Sin":
                    return new Sin();
                case "Cos":
                    return new Cos();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }

}