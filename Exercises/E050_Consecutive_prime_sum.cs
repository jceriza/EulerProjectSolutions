using Utilities;

namespace Exercises
{
    public class E050_Consecutive_prime_sum
    {
        public static int ConsecutivePrimeSum(int num)
        {
            var primes = PrimeNumbers.PrimesBelowN(num);
            int greatestPrimeSum = 0;
            int largestStreak = 0;

            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    int currentStreak = 0;
                    int currentSum = 0;

                    for (int j = i; j < primes.Length; j++)
                    {
                        if (primes[j])
                        {
                            currentSum += j;

                            if (currentSum >= num) break;
                            
                            currentStreak++;

                            if (primes[currentSum] && currentStreak > largestStreak)
                            {
                                largestStreak = currentStreak;
                                greatestPrimeSum = currentSum;
                            }
                        }
                    }
                }
            }

            return greatestPrimeSum;
        }
    }
}
