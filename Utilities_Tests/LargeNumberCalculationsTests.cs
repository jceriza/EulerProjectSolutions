using Utilities;
using Xunit;

namespace Utilities_Tests
{
    public class LargeNumberCalculationsTests
    {
        [Fact]
        public void LargeNumbersCalculationsMultiplication_187x54_10098()
        {
            Assert.Equal("47898", LargeNumbersCalculations.Multiplication("887", "54"));
        }
    }
}
