using Utilities;

namespace Exercises
{
    public static class E027_Quadratic_primes
    {
        public static int ProductOfCoefficientOfQuadraticFormulaProducingMorePrimeNumbers()
        {
            var maxPrimeNumbers = int.MinValue;
            int aValue = int.MinValue;
            int bValue = int.MinValue;

            for (int a = -999; a < 1000; a++)
            {
                for (int b = -1000; b <= 1000; b++)
                {
                    var n = 0;
                    var isPrime = false;
                    var numPrimeNumbers = 0;
                    do
                    {
                        var potentialPrimeNumber = n * n + a * n + b;
                        isPrime = PrimeNumbers.IsPrimeNumber(potentialPrimeNumber);
                        if (isPrime) numPrimeNumbers++;
                        n++;
                    } while (isPrime);

                    if (numPrimeNumbers > maxPrimeNumbers)
                    {
                        maxPrimeNumbers = numPrimeNumbers;
                        aValue = a;
                        bValue = b;
                    }
                }
            }

            return aValue * bValue;
        }
    }
}
