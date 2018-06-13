using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E041_Tests
    {
        [Fact]
        public void LargestPandigitalPrime()
        {
            Assert.Equal(
                7652413,
                E041_Pandigital_prime.LargestPandigitalPrime());
        }
    }
}
