using System.Linq;

namespace Utilities
{
    public static class AmicableNumber
    {
        public static bool IsAmicable(long number)
        {
            var first = Divisors.ProperDivisors(number).Sum();

            return first != number && number == Divisors.ProperDivisors(first).Sum();
        }
    }
}
