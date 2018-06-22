using Utilities;
using Xunit;

namespace Utilities_Tests
{
    public class BinaryNumberTests
    {
        [Theory]
        [InlineData("1110001111111101111101110110001000111110001100001100101001011000001110001010100101010000000000000000000000000000000000", "295950609069496384270872084480000000")]
        [InlineData("10000000011000010010110001101100110100", "137846528820")]
        [InlineData("100010011101000000001111110101010101101", "295950609069")]
        public void LargeBinaryNumber(string expected, string largeNumber)
        {
            Assert.Equal(
                new BinaryNumber(expected),
                new BinaryNumber(new LargeNumber(largeNumber)));
        }

        [Theory]
        [InlineData("101", "111", "10")]
        [InlineData("100", "110", "10")]
        [InlineData("10", "101", "11")]
        [InlineData("110", "1001", "11")]
        [InlineData("1010", "1101", "11")]
        [InlineData("1101", "10001", "100")]
        public void BinarySubtract(string expected, string left, string right)
        {
            Assert.Equal(
                new BinaryNumber(expected),
                new BinaryNumber(left) - new BinaryNumber(right));
        }

        [Theory]
        [InlineData("10110", "1011", "1011")]
        [InlineData("1000", "101", "11")]
        [InlineData("1110", "111", "111")]
        [InlineData("10100", "1010", "1010")]
        [InlineData("100111", "11101", "1010")]
        [InlineData("111110", "11111", "11111")]
        public void BinarySum(string expected, string left, string right)
        {
            Assert.Equal(
                new BinaryNumber(expected),
                new BinaryNumber(left) + new BinaryNumber(right));
        }

        [Theory]
        [InlineData("100", "10", "10")]
        [InlineData("1100", "100", "11")]
        [InlineData("1010", "101", "10")]
        [InlineData("100001", "1011", "11")]
        [InlineData("10000111", "11011", "101")]
        public void BinaryMultiplication(string expected, string left, string right)
        {
            Assert.Equal(
                new BinaryNumber(expected),
                new BinaryNumber(left) * new BinaryNumber(right));
        }

        [Theory]
        [InlineData("10", "100", "10")]
        [InlineData("10", "111", "11")]
        [InlineData("10", "1010", "100")]
        [InlineData("100", "1101", "11")]
        [InlineData("1011", "10111", "10")]
        public void BinaryDivision(string expected, string left, string right)
        {
            Assert.Equal(
                new BinaryNumber(expected),
                new BinaryNumber(left) / new BinaryNumber(right));
        }
    }
}
