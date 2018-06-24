using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public class PrimeNumbers
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

        public static List<long> PrimesBelowN(int num, int from = 2)
        {
            var primes = Enumerable.Range(2, num - 2).ToDictionary(n => (long)n, n => true);
            var limit = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 2; i <= limit; i++)
            {
                if (primes[i])
                {
                    var iSquare = i * i;
                    
                    for (int cont = 0, j = iSquare; j < num; cont++, j = iSquare + cont * i)
                    {
                        primes[j] = false;
                    }
                }
            }

            return primes.Where(p => p.Value && p.Key >= from).Select(p => p.Key).ToList();
        }

        public static bool IsPrimeNumber(long num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var limit = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= limit; i += 2)
                if (num % i == 0) return false;

            return true;
        }

        public static long NthPrimeNumber(int n)
        {
            long num = 0;

            for (int i = 2; n > 0; i++)
            {
                if (IsPrimeNumber(i)) n--;
                if (n == 0) num = i;
            }

            return num;
        }
    }
}
