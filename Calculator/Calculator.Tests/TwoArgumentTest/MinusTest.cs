using NUnit.Framework;

namespace Calculator.Tests
{
    public class MinusTest
    {
        [TestCase(2, 4, -2)]
        [TestCase(100, 1, 99)]
        [TestCase(200, 0, 200)]
        [TestCase(3, 20, -17)]
        public void TestMinus(double firstArgument, double secondArgument, double output)
        {
            var calculator = new Minus();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(output, testResult, 0.0000001);
        }
    }
}