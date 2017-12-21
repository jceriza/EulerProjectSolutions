using System;
using System.Collections.Generic;

namespace Utilities
{
    public static class PrimeNumbers
    {
        public static IEnumerable<long> PrimesGeneratorFrom2()
        {
            for (int i = 1; true; i++)
            {
                if (IsPrimeNumber(i))
                {
                    yield return i;
                }
            }
        }

        private static bool IsPrimeNumber(long num)
        {
            if (num == 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var limit = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= limit; i += 2)
                if (num % i == 0) return false;

            return true;
        }
    }
}
