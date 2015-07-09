using Calculator.ClassesTwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentTest
{
    /// <summary>
    /// UNint test for cosinus multiply
    /// </summary>
    public class MultiplyTest
    {
        [TestCase(2, 4, 8)]
        [TestCase(100, 1, 100)]
        [TestCase(200, 0, 0)]
        [TestCase(3, 20, 60)]
        public void TestMultiply(double firstArgument, double secondArgument, double output)
        {
            var calculator = new Multiply();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(output, testResult, 0.0000001);
        }   
    }
}