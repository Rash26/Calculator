using Calculator.ClassesSorts;
using NUnit.Framework;

namespace Calculator.Tests.TestSort
{
    public class SelectionTest : AbstractSortTest
    {
        [SetUp]
        public void Initialize()
        {
            Sorter=new SelectionSort();
        }
    }
}