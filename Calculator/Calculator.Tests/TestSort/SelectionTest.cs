using Calculator.ClassesSorts;
using NUnit.Framework;

namespace Calculator.Tests.TestSort
{
    public class SelectionTest : AbstractSortTest
    {
        [SetUp]

        public void initialize()
        {
            Sorter=new SelectionSort();
        }
    }
}