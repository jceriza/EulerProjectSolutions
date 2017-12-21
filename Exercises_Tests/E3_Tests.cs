using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E3_Tests
    {
        [Fact]
        public void LargestPrimeFactor_29()
        {
            var largestPrimeFactor = E3_Largest_prime_factor.LargestPrimeFactor(13195);

            Assert.Equal(29, largestPrimeFactor);
        }

        [Fact]
        public void LargestPrimeFactor_600851475143()
        {
            var largestPrimeFactor = E3_Largest_prime_factor.LargestPrimeFactor(600851475143);

            Assert.Equal(6857, largestPrimeFactor);
        }
    }
}
