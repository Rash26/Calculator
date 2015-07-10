using System;
using Calculator.ClassesOneArguments;
using NUnit.Framework;

namespace Calculator.Tests.FactoryTest
{
    /// <summary>
    /// UNint test for factory one argument
    /// </summary>
    public class FactoryOneArgumentTest
    { 
        [TestCase("Sin", typeof(Sin))]
        [TestCase("Cos", typeof(Cos))]
        [TestCase("Tan", typeof(Tan))]
        [TestCase("Cot", typeof(Cot))]
        [TestCase("Sqrt", typeof(Sqrt))]
        [TestCase("Squaring", typeof(Squaring))]
        public void OneArgumentTest(string name, Type type)
        {
            var calculator = FactoryOneArgument.CreatCalculator(name);
            Assert.AreEqual(type, calculator.GetType());
        }
    }
}