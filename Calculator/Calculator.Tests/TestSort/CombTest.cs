using Calculator.ClassesSorts;
using NUnit.Framework;

namespace Calculator.Tests.TestSort
{
    /// <summary>
    /// UNint test for comb sort
    /// </summary>
    public class CombTest : AbstractSortTest
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new CombSort();
        }
    }
}