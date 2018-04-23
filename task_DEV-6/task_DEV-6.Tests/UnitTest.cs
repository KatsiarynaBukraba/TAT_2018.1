using NUnit.Framework;
using System;


namespace task_DEV_6.Tests
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void SetTypeNullTest()
        {
            var product = new ProductBuilder();
            Assert.Throws<ArgumentException>(() => product.SetType(string.Empty));
        }
        [Test]
        public void SetNameNullTest()
        {
            var product = new ProductBuilder();
            Assert.Throws<ArgumentException>(() => product.SetName(string.Empty));
        }
    }
}
