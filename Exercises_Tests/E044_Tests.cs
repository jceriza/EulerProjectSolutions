using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E044_Tests
    {
        [Fact]
        public void MinimisedPentagonal()
        {
            Assert.Equal(
                5482660,
                E044_Pentagon_numbers.MinimisedPentagonalNumbersDifference());
        }
    }
}
