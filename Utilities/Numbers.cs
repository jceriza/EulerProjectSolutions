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

        public static int Pow(this int a, int b)
        {
            if (a <= 1) return a;

            var pow = a;

            while (b-- > 1) pow *= a;

            return pow;
        }
    }
}
