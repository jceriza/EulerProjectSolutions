using System.Collections.Generic;

namespace Utilities
{
    public static class TriangleNumbers
    {
        public static IEnumerable<long> Generator()
        {
            long number = 0;

            for (int i = 1; true; i++)
            {
                number += i;

                yield return number;
            }
        }
    }
}
