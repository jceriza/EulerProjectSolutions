using Utilities;

namespace Exercises
{
    public static class E036_Double_base_palindromes
    {
        public static long SumDoubleBasePalindromesUnderOneMillion()
        {
            var sum = 0L;

            for (int i = 0; i < 1_000_000; i++)
            {
                if (Palindrome.IsPalindrome(i.ToString())
                    && Palindrome.IsPalindrome(new BinaryNumber(i).ToString()))
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
