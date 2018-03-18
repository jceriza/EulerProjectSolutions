using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public static class AmicableNumber
    {
        private static Dictionary<long, long> _factorsCache = new Dictionary<long, long>();

        private static long GetFactorsSum(long number)
        {
            if (_factorsCache.ContainsKey(number))
            {
                return _factorsCache[number];
            }

            long sum = Divisors.ProperDivisors(number).Sum();

            _factorsCache.Add(number, sum);

            return sum;
        }

        public static bool IsAmicable(long number)
        {
            var first = GetFactorsSum(number);

            if (first != number && number == GetFactorsSum(first))
            {
                return true;
            }

            return false;
        }
    }
}
