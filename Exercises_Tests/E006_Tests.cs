using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E006_Tests
    {
        [Fact]
        public void SumSquareDifference_2640()
        {
            var sum = E006_Sum_square_difference.SumSquareDifference(10);

            Assert.Equal(2640, sum);
        }

        [Fact]
        public void SumSquareDifference_25164150()
        {
            var sum = E006_Sum_square_difference.SumSquareDifference(100);

            Assert.Equal(25164150, sum);
        }
    }
}
