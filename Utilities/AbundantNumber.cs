using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public static class AbundantNumber
    {
        public static IEnumerable<int> Generate()
        {
            for (int i = 1; true; i++)
            {
                if (IsAbundant(i))
                {
                    yield return i;
                }
            }
        }

        public static bool IsAbundant(int number)
        {
            return Divisors.ProperDivisors(number).Sum() > number;
        }
    }
}
