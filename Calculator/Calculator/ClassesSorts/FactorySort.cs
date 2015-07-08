using System;

namespace Calculator.ClassesSorts
{
    public static class FactorySort
    {
        public static ISort CreatCalculator(string calculator)
        {
            switch (calculator)
            {
               case "Bubble":
                    return new BubbleSorts();
                case "SelectionSort":
                    return new SelectionSort();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}