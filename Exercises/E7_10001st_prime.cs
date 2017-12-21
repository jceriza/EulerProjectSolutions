using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E7_10001st_prime
    {
        public static long Get10001stPrimeNumber()
        {
            return PrimeNumbers.PrimesGeneratorFrom2().Skip(10000).First();
        }
    }
}
