using Calculator.ClassesSorts;
using NUnit.Framework;

namespace Calculator.Tests.TestSort
{
    /// <summary>
    /// UNint test for gnome sort
    /// </summary>
    public class GnomeTest : AbstractSortTest
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new GnomeSort();
        }
    }
}