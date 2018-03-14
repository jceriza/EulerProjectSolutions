using Utilities;
using Xunit;

namespace Utilities_Tests
{
    public class AmicableNumbersTests
    {
        [Fact]
        public void AmicableNumber_220()
        {
            Assert.True(AmicableNumber.IsAmicable(220));
        }

        [Fact]
        public void AmicableNumber_284()
        {
            Assert.True(AmicableNumber.IsAmicable(284));
        }
    }
}
