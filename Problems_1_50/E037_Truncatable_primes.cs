using Utilities;

namespace Exercises
{
    public class E037_Truncatable_primes
    {
        private readonly bool[] _primeNumbers; 

        public E037_Truncatable_primes()
        {
            _primeNumbers = PrimeNumbers.PrimesUntilN(1_000_000);
        }

        private bool IsTruncatablePrime(int num)
        {
            if (!_primeNumbers[num]) return false;

            var leftToRight = 1;
            var rightToLeft = 10;
            var aux = num;

            while (aux > 10)
            {
                aux /= 10;
                leftToRight *= 10;
            }

            while (leftToRight > 1)
            {
                if (!_primeNumbers[num / leftToRight]
                    || !_primeNumbers[num % rightToLeft])
                    return false;

                leftToRight /= 10;
                rightToLeft *= 10;
            }

            return true;
        }
        
        public int TruncatablePrimesSum()
        {
            var sum = 0;

            for (int i = 11, count = 0; count < 11; i += 2)
            {
                if (IsTruncatablePrime(i))
                {
                    sum += i;

                    count++;
                }
            }

            return sum;
        }
    }
}
