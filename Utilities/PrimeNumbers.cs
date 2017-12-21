using System.Collections.Generic;

namespace Utilities
{
    public static class PrimeNumbers
    {
        public static IEnumerable<long> PrimesGeneratorFrom2()
        {
            yield return 2;

            for (int i = 3; true; i += 2)
            {
                if (IsPrimeNumber(i))
                {
                    yield return i;
                }
            }
        }

        private static bool IsPrimeNumber(long num)
        {
            if (num <= 3) return true;
            if (num % 2 == 0) return false;

            var limit = num / 2;

            for (int i = 3; i < limit; i += 2)
                if (num % i == 0) return false;

            return true;
        }
    }
}
