using System;
using System.Collections.Generic;
using Utilities;

namespace Exercises
{
    public static class E004_Largest_palindrome_product
    {
        private static HashSet<(int, int)> _numbersUsed = new HashSet<(int, int)>();

        public static int LargestXDigitPalindrome(int numberDigits)
        {
            var largestPalindrome = -1;
            var topLimit = Convert.ToInt32(Math.Pow(10, numberDigits));
            var bottomLimit = topLimit / 10;

            for (int i = topLimit - 1; i > bottomLimit; i--)
            {
                for (int j = topLimit - 1; j > bottomLimit; j--)
                {
                    if (!_numbersUsed.Contains((i, j))
                        && !_numbersUsed.Contains((j, i)))
                    {
                        _numbersUsed.Add((i, j));

                        var multiplication = i * j;

                        if (Palindrome.IsPalindrome(multiplication.ToString())
                            && multiplication > largestPalindrome)
                        {
                            largestPalindrome = multiplication;
                        }
                    }
                }
            }

            return largestPalindrome;
        }
    }
}
