using Utilities;

namespace Exercises
{
    public class E035_Circular_primes
    {
        private readonly bool[] _primeNumbers;
        private readonly int _threshold;

        public E035_Circular_primes(int threshold)
        {
            _threshold = threshold;
            _primeNumbers = PrimeNumbers.PrimesUntilN(_threshold - 1);
        }

        private bool IsCircularPrimeNumber(int number)
        {
            if (!_primeNumbers[number]) return false;

            if (number < 10) return true;

            var aux = number;
            var mult = 1;
            var length = 0;

            while (aux > 0)
            {
                aux /= 10;
                mult *= 10;
                length++;
            }

            mult /= 10;

            var numbers = new int[length - 1];
            aux = number;

            for (int i = 0; i < length - 1; i++)
            {
                var numberToMove = (aux % 10);

                aux /= 10;

                aux += numberToMove * mult;

                if (!_primeNumbers[aux]) return false;
            }

            return true;
        }

        public int NumCircularPrimes()
        {
            var circularPrimes = 0;

            for (int i = 0; i < 10; i++)
            {
                if (IsCircularPrimeNumber(i)) circularPrimes++;
            }

            for (int i = 11; i < _threshold; i += 2)
            {
                if (IsCircularPrimeNumber(i)) circularPrimes++;
            }

            return circularPrimes;
        }
    }
}
