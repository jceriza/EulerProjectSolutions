using Exercises;
using System.Collections.Generic;
using Utilities;
using Xunit;

namespace Exercises_Tests
{
    public class E048_Tests
    {
        [Fact]
        public void SelfPowerSeriesSumUntil10()
        {
            Assert.Equal(
                new LargeNumber(10405071317),
                E048_Self_powers.SelfPowerSeriesSumUntilN(10));
        }

        [Fact]
        public void SelfPowerSeriesSumUntil1000()
        {
            var numberString = E048_Self_powers.SelfPowerSeriesSumUntilN(1000).ToString();

            Assert.Equal(
                "9110846700",
                numberString.Substring(numberString.Length - 10));
        }
    }
}
