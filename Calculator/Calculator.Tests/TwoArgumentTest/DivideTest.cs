﻿using NUnit.Framework;

namespace Calculator.Tests
{
    public class DivideTest
    {
        [TestCase(4, 2, 2)]
        [TestCase(100, 1, 100)]
        [TestCase(0, 200, 0)]
        [TestCase(144, 12, 12)]
        public void TestDivide(double firstArgument, double secondArgument, double output)
        {
            var calculator = new Divide();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(output, testResult, 0.0000001);
        }
    }
}