using Utilities;
using Xunit;

namespace Utilities_Tests
{
    public class LargeNumberCalculationsTests
    {
        [Fact]
        public void Multiplication_187x54_10098()
        {
            Assert.Equal("47898", LargeNumbersCalculations.Multiplication("887", "54"));
        }

        [Fact]
        public void Factorial_10()
        {
            Assert.Equal("3628800", LargeNumbersCalculations.Factorial(10));
        }

        [Fact]
        public void Factorial_100()
        {
            Assert.Equal(
                "93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000",
                LargeNumbersCalculations.Factorial(100));
        }
    }
}
