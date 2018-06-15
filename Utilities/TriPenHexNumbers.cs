using System;

namespace Utilities
{
    public static class TriPenHexNumbers
    {
        public static double PentagonNumberIndex(long n)
        {
            return (1 + Math.Sqrt(24 * n + 1)) / 6;
        }

        public static long PentagonNumber(long n)
        {
            return n * (3 * n - 1) / 2;
        }

        public static bool IsPentagonNumber(long n)
        {
            return PentagonNumberIndex(n) % 1 == 0;
        }

        public static double TriangleNumberIndex(long n)
        {
            return (-1 + Math.Sqrt(1 + 8 * n)) / 2;
        }

        public static bool IsTriangleNumber(long n)
        {
            return TriangleNumberIndex(n) % 1 == 0;
        }

        public static long TriangleNumber(int n)
        {
            return (n * (n + 1)) / 2;
        }

        public static long HexagonalNumber(int n)
        {
            return n * (2 * n - 1);
        }
    }
}
