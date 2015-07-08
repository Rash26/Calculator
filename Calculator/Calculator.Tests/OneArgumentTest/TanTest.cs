using NUnit.Framework;

namespace Calculator.Tests
{
    public class TanTest
    {
        [TestCase(0, 0)]
        [TestCase(45, 1)]
        [TestCase(180, 0)]
        [TestCase(3, 20)]
        public void TestTan(double firstArgument, double output)
        {
            var calculator = new Tan();
            var testResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(testResult, output, 0.0000001);
        }
    }
}