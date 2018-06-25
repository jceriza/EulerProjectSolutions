using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E050_Tests
    {
        [Fact]
        public void ConsecutivePrimeSumUnder100()
        {
            Assert.Equal(
                41,
                E050_Consecutive_prime_sum.ConsecutivePrimeSum(100));
        }

        [Fact]
        public void ConsecutivePrimeSumUnder1_000()
        {
            Assert.Equal(
                953,
                E050_Consecutive_prime_sum.ConsecutivePrimeSum(1_000));
        }

        [Fact]
        public void ConsecutivePrimeSumUnder1_000_000()
        {
            Assert.Equal(
                997651,
                E050_Consecutive_prime_sum.ConsecutivePrimeSum(1_000_000));
        }
    }
}
