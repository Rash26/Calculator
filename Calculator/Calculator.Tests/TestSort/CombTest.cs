using Calculator.ClassesSorts;
using NUnit.Framework;

namespace Calculator.Tests.TestSort
{
    public class CombTest : AbstractSortTest
    {
        [SetUp]

        public void initialize()
        {
            Sorter = new CombSort();
        }
    }
}