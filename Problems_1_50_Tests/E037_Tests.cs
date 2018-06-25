using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E037_Tests
    {
        [Fact]
        public void TruncatablePrimesSum()
        {
            Assert.Equal(
                748317,
                E037_Truncatable_primes.TruncatablePrimesSum());
        }
    }
}
