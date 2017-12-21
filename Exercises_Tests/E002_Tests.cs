using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E002_Tests
    {
        [Fact]
        public void SumEvenNotExceeding4Million_4613732()
        {
            var sum = E002_Even_Fibonacci_numbers.EvenSumNotExceeding4Million();

            Assert.Equal(4613732, sum);
        }
    }
}
