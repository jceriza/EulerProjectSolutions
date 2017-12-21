namespace Utilities
{
    public static class Palindrome
    {
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
