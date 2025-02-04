namespace MyLibrary.Tests;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary; // Ensure this matches your library namespace

namespace MyLibrary.Tests
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void TestExample()
        {
            Assert.AreEqual(2, 1 + 1);
        }
    }
}

