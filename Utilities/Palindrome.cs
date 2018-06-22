using System.Collections.Generic;

namespace Utilities
{
    public static class Palindrome
    {
        public static bool IsPalindrome(int num)
        {
            var nums = new List<int>();

            while (num > 0)
            {
                nums.Add(num % 10);
                num /= 10;
            }

            for (int i = 0; i < nums.Count / 2; i++)
            {
                if (nums[i] != nums[nums.Count - i - 1]) return false;
            }

            return true;
        }

        public static bool IsPalindrome(string candidate)
        {
            for (int i = 0, j = candidate.Length - 1; i < j; i++, j--)
            {
                if (candidate[i] != candidate[j]) return false;
            }

            return true;
        }
    }
}
