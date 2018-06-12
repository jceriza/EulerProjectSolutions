using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E038_Tests
    {
        [Fact]
        public void TruncatablePrimesSum()
        {
            Assert.Equal(
                932718654,
                E038_Pandigital_multiples.LargestPandigitalFormedWithMultiples());
        }
    }
}
