using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E012_Tests
    {
        [Fact]
        public void FirstTriangleNumberWithOverFiveHundredDivisors()
        {
            Assert.Equal(
                76576500,
                E012_Highly_divisible_triangular_number.FirstTriangleNumberWithOverFiveHundredDivisors());
        }
    }
}
