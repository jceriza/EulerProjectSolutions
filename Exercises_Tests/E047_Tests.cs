using Exercises;
using System.Collections.Generic;
using Xunit;

namespace Exercises_Tests
{
    public class E047_Tests
    {
        [Fact]
        public void First2NumbersWith2PrimeFactors()
        {
            Assert.Equal(
                14,
                E047_Distinct_primes_factors.FirstNNumbersWithNPrimeFactors(2));
        }

        [Fact]
        public void First3NumbersWith3PrimeFactors()
        {
            Assert.Equal(
                644,
                E047_Distinct_primes_factors.FirstNNumbersWithNPrimeFactors(3));
        }

        [Fact]
        public void First4NumbersWith4PrimeFactors()
        {
            Assert.Equal(
                134043,
                E047_Distinct_primes_factors.FirstNNumbersWithNPrimeFactors(4));
        }
    }
}
