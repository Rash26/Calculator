using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class SquaringTest
    {
        [TestCase(5,25)]
        [TestCase(6, 36)]
        [TestCase(2, 4)]
        [TestCase(3, 9)]
        public void TestSquaring(double firstArgument, double output)
        {
            var calculator = new Squaring();
            var testResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(output, testResult, 0.0000001);
        }
    }
}