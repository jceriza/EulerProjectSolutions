using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E023_Non_abundant_sums
    {
        private static readonly List<int> _abundantNumbers;

        static E023_Non_abundant_sums()
        {
            _abundantNumbers = AbundantNumber.Generate().TakeWhile(a => a <= 28123).ToList();
        }

        private static bool IsSumFromAbundantNumbers(int num)
        {
            for (int i = 0; _abundantNumbers[i] < num; i++)
            {
                if (_abundantNumbers.BinarySearch(num - _abundantNumbers[i]) >= 0) return true;
            }

            return false;
        }

        public static int SumOfPositiveIntegersNotSumOfAbundantNumbers()
        {
            var sum = 0;

            for (int i = 1; i <= 28123; i++)
            {
                if (!IsSumFromAbundantNumbers(i))
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
