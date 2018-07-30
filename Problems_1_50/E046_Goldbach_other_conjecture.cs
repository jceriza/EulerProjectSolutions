using Utilities;

namespace Exercises
{
    public class E046_Goldbach_other_conjecture
    {
        private readonly bool[] _primeNumbers;

        public E046_Goldbach_other_conjecture()
        {
            _primeNumbers = PrimeNumbers.PrimesUntilN(10_000);
        }

        private bool CompliesWithGoldbachConjecture(int number)
        {
            for (int potentialPrime = 0; potentialPrime <= number; potentialPrime++)
            {
                if (_primeNumbers[potentialPrime])
                {
                    var rest = number - potentialPrime;

                    var i = 1;
                    int mult;

                    do
                    {
                        mult = 2 * (i * i++);
                    } while (mult < rest);

                    if (mult == rest) return true;
                }
            }

            return false;
        }

        private bool IsComposite(int number)
        {
            return !_primeNumbers[number];
        }

        public long SmallestOddNotGoldbach()
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
