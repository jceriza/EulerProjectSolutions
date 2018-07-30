using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public static class Fraction
    {
        public static int UnitFractionCycleLength(int divisor)
        {
            var divisors = new List<(int numDecimals, int remainder)>();

            var dividend = 1;
            int remainder = 1;
            var cycleFound = false;

            do
            {
                var numDecimals = 0;

                while (dividend / divisor == 0)
                {
                    dividend *= 10;
                    numDecimals++;
                }

                divisors.Add((numDecimals, remainder));
                
                remainder = dividend % divisor;
                dividend = remainder;

                if (divisors.Any(d => d.remainder == remainder))
                    cycleFound = true;
            } while (remainder != 0 && !cycleFound);

            if (!cycleFound) return 0;

            return divisors.SkipWhile(d => d.remainder != remainder).Sum(d => d.numDecimals);
        }
    }
}
