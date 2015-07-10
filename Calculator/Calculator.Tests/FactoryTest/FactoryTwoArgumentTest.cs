using System;
using Calculator.ClassesTwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.FactoryTest
{
    /// <summary>
    /// UNint test for factory one argument
    /// </summary>
    public class FactoryTwoArgumentTest
    {
        [TestCase("Added", typeof(Added))]
        [TestCase("Minus", typeof(Minus))]
        [TestCase("Multiply", typeof(Multiply))]
        [TestCase("Power", typeof(Power))]
        [TestCase("Divide", typeof(Divide))]
        public void OneArgumentTest(string name, Type type)
        {
            var calculator = FactoryTwoArgument.CreatCalculator(name);
            Assert.AreEqual(type, calculator.GetType());
        }
    }
}