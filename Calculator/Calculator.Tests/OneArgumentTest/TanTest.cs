﻿using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class TanTest
    {
        [TestCase(0, 0)]
        [TestCase(45, 1)]
        [TestCase(180, 0)]
        [TestCase(360, 0)]
        public void TestTan(double firstArgument, double output)
        {
            var calculator = new Tan();
            var testResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(output, testResult, 0.0000001);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void TangensNaNTest()
        {
            var calculator = new Tan();
            var result = calculator.Calculate(90);
        }
    }
}