using Exercises;
using System.Collections.Generic;
using Xunit;

namespace Exercises_Tests
{
    public class E031_Tests
    {
        [Fact]
        public void WaysToGet2Pounds()
        {
            Assert.Equal(
                73682,
                E031_Coin_sums.WaysToGetXPounds(200));
        }
    }
}
