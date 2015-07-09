using Calculator.ClassesSorts;
using NUnit.Framework;

namespace Calculator.Tests.TestSort
{
    /// <summary>
    /// UNint test for bubble sort
    /// </summary>
    public class BubbleTest : AbstractSortTest
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new BubbleSorts();
        }
    }
}