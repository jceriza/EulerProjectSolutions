using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E014_Tests
    {
        [Fact]
        public void FirstTriangleNumberWithOverFiveHundredDivisors()
        {
            Assert.Equal(
                837799,
                E014_Longest_Collatz_sequence.LongestSeriesUnderOneMillion());
        }
    }
}
