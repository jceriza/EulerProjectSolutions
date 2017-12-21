using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E5_Tests
    {
        [Fact]
        public void SmallestMultipleTo10_2520()
        {
            var smallestMultiple = E5_Smallest_Multiple.SmallestMultiple(10);

            Assert.Equal(2520, smallestMultiple);
        }

        [Fact]
        public void SmallestMultipleTo20_232792560()
        {
            var smallestMultiple = E5_Smallest_Multiple.SmallestMultiple(20);

            Assert.Equal(232792560, smallestMultiple);
        }
    }
}
