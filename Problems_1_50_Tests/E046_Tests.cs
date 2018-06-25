using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E046_Tests
    {
        [Fact]
        public void GoldbachOtherConjecture()
        {
            Assert.Equal(
                5777,
                E046_Goldbach_other_conjecture.SmallestOddNotGoldbach());
        }
    }
}
