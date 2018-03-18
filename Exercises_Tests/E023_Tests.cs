using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E023_Tests
    {
        [Fact]
        public void NonAbundantSums()
        {
            Assert.Equal(
                4179871,
                E023_Non_abundant_sums.SumOfPositiveIntegersNotSumOfAbundantNumbers());
        }
    }
}
