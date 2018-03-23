using System;
using System.Linq;
using Xunit;
using task_DEV_2;

namespace task_DEV_2.Tests
{
    public class UnitTest
    {
        private SequenceEvenIndexBuilder builder = new SequenceEvenIndexBuilder();

        [Theory]
        [InlineData("a", "a")]
        [InlineData("sa", "s")]
        [InlineData("sasasasa", "ssss")]
        [InlineData("sasasasas", "sssss")]
        public void ValidSymbolsTest(string parameter, string expected)
        {
            string actual = builder.FindSequenceEvenIndex(parameter);
            Assert.Equal(expected, actual);      
        }

        [Fact]
        public void NullStringTest()
        {
            string parameter = "";
            Assert.Throws<ArgumentNullException>(() => builder.FindSequenceEvenIndex(parameter));
        }
    }
}
