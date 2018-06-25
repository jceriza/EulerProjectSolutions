using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E016_Tests
    {
        [Fact]
        public void PowerDigitSum_2Pow15_26()
        {
            Assert.Equal(
                26,
                E016_Power_digit_sum.PowerOf2(15));
        }

        [Fact]
        public void PowerDigitSum_2Pow1000_1366()
        {
            Assert.Equal(
                1366,
                E016_Power_digit_sum.PowerOf2(1000));
        }
    }
}
