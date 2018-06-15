using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E046_Goldbach_other_conjecture
    {
        private static bool CompliesWithGoldbachConjecture(int number)
        {
            var primes = PrimeNumbers.PrimesGeneratorFrom2().TakeWhile(prime => prime <= number);

            foreach (var prime in primes)
            {
                var rest = number - prime;

                var i = 1;
                int mult;

                do
                {
                    mult = 2 * (i * i++);
                } while (mult < rest);

                if (mult == rest) return true;
            }

            return false;
        }

        private static bool IsComposite(int number)
        {
            return !PrimeNumbers.IsPrimeNumber(number);
        }

        public static long SmallestOddNotGoldbach()
        {
            int number = 1;
            do
            {
                number += 2;
                while (!IsComposite(number)) number += 2;
            } while (CompliesWithGoldbachConjecture(number));

            return number;
        }
    }
}
