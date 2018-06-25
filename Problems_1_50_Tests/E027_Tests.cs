using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E027_Tests
    {
        [Fact]
        public void NonAbundantSums()
        {
            Assert.Equal(
                -59231,
                E027_Quadratic_primes.ProductOfCoefficientOfQuadraticFormulaProducingMorePrimeNumbers());
        }
    }
}
