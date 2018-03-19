using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E025_Tests
    {
        [Fact]
        public void OneThousandFibonacciNumber()
        {
            Assert.Equal(
                4782,
                E025_1000_digit_Fibonacci_number.IndexOf1000DigitFibonacciNumber());
        }
    }
}
