using Calculator.ClassesOneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTest
{
    public class SqrtTest
    {
        [TestCase(25, 5)]
        [TestCase(36, 6)]
        [TestCase(144, 12)]
        [TestCase(9, 3)]
        public void TestSqrt(double firstArgument, double output)
        {
            var calculator = new Sqrt();
            var testResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(output, testResult, 0.0000001);
        }
    }
}