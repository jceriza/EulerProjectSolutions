using System.Collections.Generic;

namespace Utilities
{
    public static class Numbers
    {
        public static long JoinWith(this long a, long b)
        {
            var aux = b;

            while (aux > 0)
            {
                aux /= 10;
                a *= 10;
            }

            return a + b;
        }

        public static int JoinWith(this int a, int b)
        {
            var aux = b;

            while (aux > 0)
            {
                aux /= 10;
                a *= 10;
            }

            return a + b;
        }

        private static long BiggestSquare(long num)
        {
            if (num < 1) return 0;
            var found = false;
            long square = 1;
            long mult = 1;

            for (long i = 1; !found; i++)
            {
                square = mult;
                mult = i * i;

                if (mult > num) found = true;
            }

            return square;
        }
    }
}
