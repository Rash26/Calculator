using NUnit.Framework;

namespace Calculator.Tests
{
    public class SinTest
    {
        [TestCase(0, 0)]
        [TestCase(90, 1)]
        [TestCase(180, 0)]
        [TestCase(10, 10)]
        public void TestSin(double firstArgument, double output)
        {
            var calculator = new Sin();
            var testResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(testResult, output, 0.00001);
        }
    }
}