using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E007_10001st_prime
    {
        public static long Get10001stPrimeNumber()
        {
            return PrimeNumbers.NthPrimeNumber(10_001);
        }
    }
}
