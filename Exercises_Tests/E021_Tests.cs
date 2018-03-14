using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E021_Tests
    {
        [Fact]
        public void SumOfAmicableNumbersUnder10000()
        {
            Assert.Equal(
                31626,
                E021_Amicable_numbers.SumOfAmicableNumbersUnder10000());
        }
    }
}
