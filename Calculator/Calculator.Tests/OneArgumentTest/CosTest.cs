using Calculator.ClassesOneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTest
{
    public class CosTest
    {
        [TestCase(60, 0.5)]
        [TestCase(90, 0)]
        [TestCase(180, -1)]
        [TestCase(240, -0.5)]
        public void TestCos(double firstArgument, double output)
        {
            var calculator = new Cos();
            var testResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(output, testResult, 0.0000001);
        }
    }
}