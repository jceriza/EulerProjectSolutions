using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E034_Tests
    {
        [Fact]
        public void DigitFactorials()
        {
            Assert.Equal(
                40730,
                E034_Digit_factorials.SumNumbersEqualSumFactorialDigits());
        }
    }
}
