using Calculator.ClassesTwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentTest
{
    public class AddedTest
    {
        [TestCase(2, 4, 6)]
        [TestCase(100, 1, 101)]
        [TestCase(200, 0, 200)]
        [TestCase(30, 20, 50)]
        public void TestAdded(double firstArgument,double secondArgument, double output)
        {
            var calculator = new Added();
            var testResult = calculator.Calculate(firstArgument,secondArgument);
            Assert.AreEqual(output, testResult, 0.0000001);
        }
    }
}