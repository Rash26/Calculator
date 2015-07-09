using Calculator.ClassesSorts;
using NUnit.Framework;

namespace Calculator.Tests.TestSort
{
    public class GnomeTest : AbstractSortTest
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new GnomeSort();
        }
    }
}