using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E035_Tests
    {
        [Fact]
        public void CircularPrimesUnder_100_13()
        {
            Assert.Equal(
                13,
                E035_Circular_primes.NumCircularPrimesBelowN(100));
        }

        [Fact]
        public void CircularPrimesUnder_1000000_X()
        {
            Assert.Equal(
                55,
                E035_Circular_primes.NumCircularPrimesBelowN(1_000_000));
        }
    }
}
