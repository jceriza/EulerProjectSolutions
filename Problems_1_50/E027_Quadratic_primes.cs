using Utilities;

namespace Exercises
{
    public class E027_Quadratic_primes
    {
        public static int ProductOfCoefficientOfQuadraticFormulaProducingMorePrimeNumbers()
        {
            var maxPrimeNumbers = int.MinValue;
            int aValue = int.MinValue;
            int bValue = int.MinValue;
            var primesUntil999 = PrimeNumbers.PrimesUntilN(999);

            for (int a = -999; a < 1000; a++)
            {
                for (int b = 2; b <= 999; b++)
                {
                    if (primesUntil999[b])
                    {
                        int n;

                        for (n = 1; PrimeNumbers.IsPrimeNumber(n * n + a * n + b); n++) ;

                        if (n > maxPrimeNumbers)
                        {
                            maxPrimeNumbers = n;
                            aValue = a;
                            bValue = b;
                        }
                    }
                }
            }

            return aValue * bValue;
        }
    }
}
