using Utilities;

namespace Exercises
{
    public class E041_Pandigital_prime
    {
        private static int PandigitalHigherPrime(int missing, int number)
        {
            if (missing == 0)
            {
                if (PrimeNumbers.IsPrimeNumber(number)) return number;

                return -1;
            }

            var aux = missing;
            var div = 10;
            var antDiv = 1;

            while (aux > 0)
            {
                var nextMissing = missing / div * antDiv + missing % antDiv;
                var nextNumber = number * 10 + aux % 10;
                var result = PandigitalHigherPrime(nextMissing, nextNumber);

                if (result > -1) return result;

                aux /= 10;
                antDiv = div;
                div *= 10;
            }

            return -1;
        }

        public static int LargestPandigitalPrime()
        {
            var result = -1;

            for (int i = 9, j = 123456789; i >= 1; i--, j /= 10)
            {
                result = PandigitalHigherPrime(j, 0);

                if (result > -1) return result;
            }

            return result;
        }
    }
}
