using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E036_Tests
    {
        [Fact]
        public void SumDoubleBasePalindromesUnderOneMillion()
        {
            Assert.Equal(
                872187,
                E036_Double_base_palindromes.SumDoubleBasePalindromesUnderOneMillion());
        }
    }
}
