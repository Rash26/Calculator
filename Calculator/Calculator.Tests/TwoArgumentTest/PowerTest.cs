using Calculator.ClassesTwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentTest
{
    public class PowerTest
    {
        [TestCase(4, 2, 16)]
        [TestCase(100, 1, 100)]
        [TestCase(200, 0, 1)]
        [TestCase(3, 5, 243)]
        public void TestPower(double firstArgument, double secondArgument, double output)
        {
            var calculator = new Power();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(output, testResult, 0.0000001);
        } 
    }
}