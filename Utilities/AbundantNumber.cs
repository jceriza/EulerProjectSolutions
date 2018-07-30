using System.Linq;

namespace Utilities
{
    public static class AbundantNumber
    {
        public static bool IsAbundant(int number)
        {
            return Divisors.ProperDivisors(number).Sum() > number;
        }
    }
}
