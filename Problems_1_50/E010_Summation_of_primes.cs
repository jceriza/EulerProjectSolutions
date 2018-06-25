using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E010_Summation_of_primes
    {
        public static long SumPrimesBelowN(int num)
        {
            var primes = PrimeNumbers.PrimesBelowN(num);
            long sum = 2;

            for (int i = 3; i < primes.Length; i += 2)
            {
                if (primes[i]) sum += i;
            }

            return sum;
        }
    }
}
