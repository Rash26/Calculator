using Calculator.ClassesSorts;
using NUnit.Framework;

namespace Calculator.Tests.TestSort
{
    /// <summary>
    /// UNint test for selection sort
    /// </summary>
    public class SelectionTest : AbstractSortTest
    {
        [SetUp]
        public void Initialize()
        {
            Sorter=new SelectionSort();
        }
    }
}