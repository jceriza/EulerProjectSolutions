using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Utilities
{
    public static class PrimeNumbers
    {
        private static readonly ConcurrentDictionary<long, bool> _primeNumbers = new ConcurrentDictionary<long, bool>();

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

        public static bool IsPrimeNumber(long num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            if (_primeNumbers.ContainsKey(num))
            {
                return _primeNumbers[num];
            }

            var limit = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= limit; i += 2)
                if (num % i == 0)
                {
                    _primeNumbers.TryAdd(num, false);
                    return false;
                }

            _primeNumbers.TryAdd(num, true);
            return true;
        }
    }
}
