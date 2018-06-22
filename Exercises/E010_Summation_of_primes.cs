using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E010_Summation_of_primes
    {
        public static long SumPrimesBelowN(int num)
        {
            return PrimeNumbers.PrimesBelowN(num).Sum();
        }
    }
}
