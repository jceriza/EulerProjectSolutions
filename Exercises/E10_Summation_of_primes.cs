using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E10_Summation_of_primes
    {
        public static long SumPrimesBelowN(int num)
        {
            return PrimeNumbers.PrimesGeneratorFrom2().TakeWhile(n => n < num).Sum();
        }
    }
}
