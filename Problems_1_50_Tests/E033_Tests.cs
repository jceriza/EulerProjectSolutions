using Exercises;
using System.Collections.Generic;
using Xunit;

namespace Exercises_Tests
{
    public class E033_Tests
    {
        [Fact]
        public void DenominatorProductFractions()
        {
            Assert.Equal(
                100,
                E033_Digit_cancelling_fractions.DenominatorProductFractions());
        }
    }
}
