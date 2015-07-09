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
                case "GnomeSort":
                    return new GnomeSort();
                case "CombSort":
                    return new CombSort();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}