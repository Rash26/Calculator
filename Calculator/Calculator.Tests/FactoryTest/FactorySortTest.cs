using System;
using Calculator.ClassesSorts;
using NUnit.Framework;

namespace Calculator.Tests.FactoryTest
{
    /// <summary>
    /// UNint test for factory one argument
    /// </summary>
    public class FactorySortTest
    {
        [TestCase("Bubble", typeof(BubbleSorts))]
        [TestCase("SelectionSort", typeof(SelectionSort))]
        [TestCase("GnomeSort", typeof(GnomeSort))]
        [TestCase("CombSort", typeof(CombSort))]
        public void OneArgumentTest(string name, Type type)
        {
            var calculator = FactorySort.CreatCalculator(name);
            Assert.AreEqual(type, calculator.GetType());
        }
    }
}