using Exercises;
using System.Collections.Generic;
using Xunit;

namespace Exercises_Tests
{
    public class E030_Tests
    {
        [Fact]
        public void SumNthPowersOfTheirDigits_4()
        {
            Assert.Equal(
                19316,
                E030_Digit_fifth_powers.SumNthPowersOfTheirDigits(4));
        }

        [Fact]
        public void SumNthPowersOfTheirDigits_5()
        {
            Assert.Equal(
                443839,
                E030_Digit_fifth_powers.SumNthPowersOfTheirDigits(5));
        }
    }
}
