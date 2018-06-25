using Utilities;

namespace Exercises
{
    public class E004_Largest_palindrome_product
    {
        public static int LargestXDigitPalindrome(int numberDigits)
        {
            var minNum = 1;

            while (--numberDigits > 0) minNum *= 10;

            var maxNum = minNum * 10;
            var largestPalindrome = 0;

            for (int i = maxNum - 1; i >= minNum; i--)
            {
                if (i * (i - 1) <= largestPalindrome) break;

                for (int j = i - 1; j >= minNum; j--)
                {
                    var mult = i * j;

                    if (mult <= largestPalindrome) break;

                    if (mult > largestPalindrome && Palindrome.IsPalindrome(mult))
                    {
                        largestPalindrome = mult;
                    }
                }
            }

            return largestPalindrome;
        }
    }
}
