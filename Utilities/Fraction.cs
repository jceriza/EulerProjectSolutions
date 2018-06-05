using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public static class Fraction
    {
        public static List<int> UnitFractionCycleDecimals(int divisor)
        {
            var dividend = 1;
            var remainder = dividend % divisor;
            var remaindersAndDecimals = new List<(int remainder, List<int> decimals)>();

            while (remainder != 0)
            {
                if (remaindersAndDecimals.Any(r => r.remainder == remainder))
                {
                    return remaindersAndDecimals
                        .SkipWhile(r => r.remainder != remainder)
                        .SelectMany(r => r.decimals)
                        .ToList();
                }

                var decimals = new List<int>();

                while (dividend < divisor)
                {
                    dividend *= 10;
                    if (dividend < divisor) decimals.Add(0);
                }

                decimals.Add(dividend / divisor);

                remaindersAndDecimals.Add((remainder, decimals));

                remainder = dividend % divisor;
                dividend = remainder;
            }

            return new List<int>();
        }
    }
}
