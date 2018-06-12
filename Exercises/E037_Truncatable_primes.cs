using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Exercises
{
    public class E037_Truncatable_primes
    {
        private static bool IsTruncatablePrime(long num)
        {
            var leftToRight = 1;
            var rightToLeft = 10;
            var aux = num;

            while (aux > 10)
            {
                aux /= 10;
                leftToRight *= 10;
            }

            while (leftToRight > 1)
            {
                if (!(PrimeNumbers.IsPrimeNumber(num / leftToRight)
                    && PrimeNumbers.IsPrimeNumber(num % rightToLeft)))
                {
                    return false;
                }

                leftToRight /= 10;
                rightToLeft *= 10;
            }

            return true;
        }
        
        public static long TruncatablePrimesSum()
        {
            var sum = 0L;
            var count = 0;

            foreach (var prime in PrimeNumbers.PrimesGeneratorFrom2().SkipWhile(p => p < 10))
            {
                if (IsTruncatablePrime(prime))
                {
                    sum += prime;

                    if (++count == 11) break;
                }
            }

            return sum;
        }
    }
}
