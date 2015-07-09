using Calculator.ClassesSorts;
using NUnit.Framework;

namespace Calculator.Tests.TestSort
{
    public class BubbleTest : AbstractSortTest
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new BubbleSorts();
        }
    }
}