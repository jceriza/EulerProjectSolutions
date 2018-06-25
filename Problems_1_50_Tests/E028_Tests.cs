using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E028_Tests
    {
        [Fact]
        public void DiagonalsSum_5_101()
        {
            Assert.Equal(
                101,
                E028_Number_spiral_diagonals.SumDiagonals(5));
        }

        [Fact]
        public void DiagonalsSum_1001_669171001()
        {
            Assert.Equal(
                669171001,
                E028_Number_spiral_diagonals.SumDiagonals(1001));
        }
    }
}
