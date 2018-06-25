using Utilities;

namespace Exercises
{
    public static class E044_Pentagon_numbers
    {
        public static long MinimisedPentagonalNumbersDifference()
        {
            for (int k = 2; true; k++)
            {
                var kPentagon = TriPenHexNumbers.PentagonNumber(k);

                for (int j = k - 1; j >= 1; j--)
                {
                    var jPentagon = TriPenHexNumbers.PentagonNumber(j);
                    var diff = kPentagon - jPentagon;

                    if (TriPenHexNumbers.IsPentagonNumber(diff) && TriPenHexNumbers.IsPentagonNumber(kPentagon + jPentagon))
                    {
                        return diff;
                    }
                }
            }
        }
    }
}
