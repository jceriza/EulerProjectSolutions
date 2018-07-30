using Utilities;
using Xunit;

namespace Utilities_Tests
{
    public class LargeNumberCalculationsTests
    {
        [Fact]
        public void Multiplication_187x54_10098()
        {
            Assert.True(new LargeNumber(887) * new LargeNumber(54) == 47898);
        }

        [Fact]
        public void LargeNumberSum()
        {
            Assert.Equal(new LargeNumber("5109094217170944009090942171709440000"),
                new LargeNumber("243290200817664000432902008176640000") + new LargeNumber("4865804016353280008658040163532800000"));
        }

        [Fact]
        public void LargeNumberMultiplication()
        {
            Assert.Equal(new LargeNumber("1183802436277985541296320998066590745417849732067353708348833792000000000"),
                new LargeNumber("243290200817664000432902008176640000") * new LargeNumber("4865804016353280008658040163532800000"));
        }

        [Fact]
        public void Factorial_10()
        {
            Assert.True(3628800 == LargeNumber.Factorial(10));
        }

        [Fact]
        public void Factorial_100()
        {
            Assert.Equal(
                new LargeNumber("93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000"),
                LargeNumber.Factorial(100));
        }

        [Theory]
        [InlineData("3892832941", "21072702125", "17179869184")]
        [InlineData("1234560236012", "1234567891011", "7654999")]
        public void LargeNumberSubtract(string expected, string left, string right)
        {
            Assert.Equal(
                new LargeNumber(expected),
                new LargeNumber(left) - new LargeNumber(right));
        }
    }
}
