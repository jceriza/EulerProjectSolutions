using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E049_Tests
    {
        [Fact]
        public void PrimePermutations()
        {
            Assert.Equal(
                296962999629,
                E049_Prime_permutations.PrimePermutations());
        }
    }
}
