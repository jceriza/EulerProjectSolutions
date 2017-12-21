using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E4_Tests
    {
        [Fact]
        public void LargestTwoDigitPalindrome_9009()
        {
            var largestPalindrome = E4_Largest_palindrome_product.LargestXDigitPalindrome(2);

            Assert.Equal(9009, largestPalindrome);
        }

        [Fact]
        public void LargestThreeDigitPalindrome_906609()
        {
            var largestPalindrome = E4_Largest_palindrome_product.LargestXDigitPalindrome(3);

            Assert.Equal(906609, largestPalindrome);
        }
    }
}
