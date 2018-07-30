using System.Collections.Generic;
using Utilities;

namespace Exercises
{
    public class E023_Non_abundant_sums
    {
        public static int SumOfPositiveIntegersNotSumOfAbundantNumbers()
        {
            const int limit = 28123;
            var _abundantNumbers = new bool[limit + 1];

            var sum = 0;

            for (int i = 1; i <= limit; i++)
            {
                if (AbundantNumber.IsAbundant(i))
                    _abundantNumbers[i] = true;

                var isSumOfTwoAbundants = false;

                for (int j = i - 1; j >= 1 && !isSumOfTwoAbundants; j--)
                {
                    if (_abundantNumbers[j] && _abundantNumbers[i - j])
                        isSumOfTwoAbundants = true;
                }

                if (!isSumOfTwoAbundants)
                    sum += i;
            }

            return sum;
        }
    }
}
