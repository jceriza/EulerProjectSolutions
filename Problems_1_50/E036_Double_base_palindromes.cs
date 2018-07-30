using Utilities;

namespace Exercises
{
    public class E036_Double_base_palindromes
    {
        public static int SumDoubleBasePalindromesUnderOneMillion()
        {
            var sum = 0;

            for (int i = 0; i < 1_000_000; i++)
            {
                if (Palindrome.IsPalindrome(i)
                    && new BinaryNumber(i).IsPalindrome())
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
