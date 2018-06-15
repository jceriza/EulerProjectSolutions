namespace Exercises
{
    public static class E047_Distinct_primes_factors
    {
        public static bool HasNPrimeFactors(int number, int n)
        {
            if (number % 2 == 0)
            {
                n--;
                do
                {
                    number /= 2;
                } while (number % 2 == 0);
            }

            for (int i = 3; n >= 0 && number > 2; i += 2)
            {
                if (number % i == 0)
                {
                    if (--n < 0) return false;

                    do
                    {
                        number /= i;
                    } while (number % i == 0);
                }
            }

            return n == 0;
        }

        public static int FirstNNumbersWithNPrimeFactors(int n)
        {
            int number = -1;
            var quantity = 0;

            for (int i = n; quantity < n; i += n)
            {
                if (HasNPrimeFactors(i, n))
                {
                    quantity = 0;

                    for (int j = i - n + 1; j < i + n && quantity < n; j++)
                    {
                        if (HasNPrimeFactors(j, n))
                        {
                            if (quantity++ == 0) number = j;
                        }
                        else quantity = 0;
                    }
                }                
            }            

            return number;
        }
    }
}
