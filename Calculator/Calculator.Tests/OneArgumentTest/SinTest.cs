using Calculator.ClassesOneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTest
{
    public class SinTest
    {
        [TestCase(0, 0)]
        [TestCase(90, 1)]
        [TestCase(180, 0)]
        [TestCase(270, -1)]
        public void TestSin(double firstArgument, double output)
        {
            var calculator = new Sin();
            var testResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(output, testResult, 0.0000001);
        }
    }
}