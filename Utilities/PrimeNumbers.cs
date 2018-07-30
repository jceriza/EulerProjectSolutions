using System;
using System.Collections.Generic;

namespace Utilities
{
    public class PrimeNumbers
    {
        public static bool[] PrimesUntilN(long num)
        {
            var primes = new bool[num + 1];

            for (int i = 2; i < primes.Length; i++) primes[i] = true;

            var limit = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 2; i <= limit; i++)
            {
                if (primes[i])
                {
                    var iSquare = i * i;
                    
                    for (int cont = 0, j = iSquare; j <= num; cont++, j = iSquare + cont * i)
                    {
                        primes[j] = false;
                    }
                }
            }
            
            return primes;
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
