using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E010_Tests
    {
        [Fact]
        public void SumPrimesBelow10_17()
        {
            var sum = E010_Summation_of_primes.SumPrimesBelowN(10);

            Assert.Equal(17, sum);
        }

        [Fact]
        public void SumPrimesBelow2000000_142913828922()
        {
            var sum = E010_Summation_of_primes.SumPrimesBelowN(2_000_000);

            Assert.Equal(142913828922, sum);
        }
    }
}
