using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E020_Tests
    {
        [Fact]
        public void SumDigitsOf10()
        {
            Assert.Equal(
                27,
                E020_Factorial_digit_sum.SumOfDigitsOfNumber(10));
        }

        [Fact]
        public void SumDigitsOf100()
        {
            Assert.Equal(
                648,
                E020_Factorial_digit_sum.SumOfDigitsOfNumber(100));
        }
    }
}
