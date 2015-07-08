using System;

namespace Calculator.ClassesTwoArguments
{
    public static class FactoryTwoArgument
    {
        public static ITwoArgument CreatCalculator(string calculator)
        {
        	switch (calculator)
            {
                case "Minus":
                    return new Minus();
                case "Multiply":
                    return new Multiply();
                case "Divide":
                    return new Divide();
                case "Added":
                    return new Added();
                case "Power":
                    return new Power();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }   
     }
}