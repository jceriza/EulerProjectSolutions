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
                new E035_Circular_primes(100).NumCircularPrimes());
        }

        [Fact]
        public void CircularPrimesUnder_1000000_X()
        {
            Assert.Equal(
                55,
                new E035_Circular_primes(1_000_000).NumCircularPrimes());
        }
    }
}
