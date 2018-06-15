using System;

namespace Utilities
{
    public class PentagonNumbers
    {
        private long PentagonNumber(long n)
        {
            return n * (3 * n - 1) / 2;
        }

        private double PentagonNumberIndex(long n)
        {
            return (1 + Math.Sqrt(24 * n + 1)) / 6;
        }

        private bool IsPentagonNumber(long n)
        {
            return PentagonNumberIndex(n) % 1 == 0;
        }

        private long Minimised()
        {
            for (int k = 2; true; k++)
            {
                var kPentagon = PentagonNumber(k);

                for (int j = k - 1; j >= 1; j--)
                {
                    var jPentagon = PentagonNumber(j);
                    var diff = kPentagon - jPentagon;

                    if (IsPentagonNumber(diff) && IsPentagonNumber(kPentagon + jPentagon))
                    {
                        return diff;
                    }
                }
            }
        }

        public static long MinimisedPentagonalNumbersDifference()
        {
            return new PentagonNumbers().Minimised();
        }
    }
}
