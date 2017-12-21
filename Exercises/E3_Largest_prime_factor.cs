using Utilities;

namespace Exercises
{
    public static class E3_Largest_prime_factor
    {
        public static long LargestPrimeFactor(long num)
        {
            long prime;

            do
            {
                prime = FirstPrimeFactor(num);
                num = num / prime;
            } while (num > 1);

            return prime;
        }

        private static long FirstPrimeFactor(long num)
        {
            foreach (var prime in PrimeNumbers.PrimesGeneratorFrom2())
            {
                if (prime >= num) break;

                if (num % prime == 0)
                {
                    return prime;
                }
            }

            return num;
        }
    }
}
