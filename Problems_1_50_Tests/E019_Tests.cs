using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E019_Tests
    {
        [Fact]
        public void CountingSundays()
        {
            Assert.Equal(
                171,
                E019_Counting_Sundays.CountSundays());
        }
    }
}
