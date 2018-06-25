using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E007_Tests
    {
        [Fact]
        public void Get10001stPrimeNumber_104743()
        {
            var prime = E007_10001st_prime.Get10001stPrimeNumber();

            Assert.Equal(104743, prime);
        }
    }
}
