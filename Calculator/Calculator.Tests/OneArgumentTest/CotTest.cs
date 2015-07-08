﻿using NUnit.Framework;

namespace Calculator.Tests
{
    public class CotTest
    {
        [TestCase(45, 1)]
        [TestCase(270, 0)]
        [TestCase(90, 0)]
        [TestCase(60, 0.577)]
        public void TestCot(double firstArgument, double output)
        {
            var calculator = new Cot();
            var testResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(output, testResult, 0.001);
        }
    }
}