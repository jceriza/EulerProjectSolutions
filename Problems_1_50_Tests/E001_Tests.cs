using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E001_Tests
    {
        [Fact]
        public void SumMultiplesUntil10_23()
        {
            var sum = E001_Multiples_of_3_or_5.SumOfMultiplesOf3Or5Below(10);

            Assert.Equal(23, sum);
        }

        [Fact]
        public void SumMultiplesUntil1000_233168()
        {
            var sum = E001_Multiples_of_3_or_5.SumOfMultiplesOf3Or5Below(1000);

            Assert.Equal(233168, sum);
        }
    }
}
