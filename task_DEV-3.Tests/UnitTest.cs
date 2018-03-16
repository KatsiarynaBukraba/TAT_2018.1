using NUnit.Framework;
using System;
using System.Numerics;

namespace task_DEV_3.Tests
{
    [TestFixture]
    public class UnitTest
    {
        [TestCase(16, 27, "1B")]
        [TestCase(2, 8, "1000")]
        [TestCase(20, 20, "10")]
        [TestCase(10, 0, "0")]
        [Test]
        public void ValidBaseValidValueTest(int validBase, int parameter, string expected)
        {
            ConverterToOtherSystem converter = new ConverterToOtherSystem(validBase);
            Assert.AreEqual(expected, converter.GetConvertedNumber(parameter));
        }

        [TestCase(10, -1)]
        [Test]
        public void NegativeValueTest(int validBase, int parameter)
        {
            ConverterToOtherSystem converter = new ConverterToOtherSystem(validBase);
            Assert.Throws<ArgumentException>(() => converter.GetConvertedNumber(parameter));
        }

        [TestCase(1)]
        [TestCase(21)]
        [Test]
        public void NegativeBasaTest(int errorBase)
        {
             Assert.Throws<ArgumentException>(() => new ConverterToOtherSystem(errorBase));
        }

    }
}
