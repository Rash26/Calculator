using NUnit.Framework;

namespace Calculator.Tests
{
    public class SqrtTest
    {
        [TestCase(25, 5)]
        [TestCase(36, 6)]
        [TestCase(144, 12)]
        [TestCase(3, 20)]
        public void TestSqrt(double firstArgument, double output)
        {
            var calculator = new Sqrt();
            var testResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(testResult, output);
        }
    }
}