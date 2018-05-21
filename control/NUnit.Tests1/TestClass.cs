using NUnit.Framework;
using System;
using task2;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [TestCase("0,000001", "0,000003", 0.000000000003)]
        [TestCase("1000000", "1000000", 1000000000000)]
        [TestCase("5", "8", 40)]
        [Test]
        public void ValidSquare(string width, string length, double expectedSquare)
        {
            string[] args = { width, length };
            Rectangle rectangle = new Rectangle(args);
            Assert.AreEqual(expectedSquare, rectangle.CalculateSquare());
        }
    }
}
