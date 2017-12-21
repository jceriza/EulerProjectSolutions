using System.Collections.Generic;

namespace Utilities
{
    public static class Fibonacci
    {
        private static readonly Dictionary<int, long> _fibonacciValues
            = new Dictionary<int, long> { { 1, 1 }, { 2, 2 } };

        private static long NFibonacciNumber(int num)
        {
            if (_fibonacciValues.TryGetValue(num, out long value))
            {
                return value;
            }

            value = NFibonacciNumber(num - 1) + NFibonacciNumber(num - 2);

            _fibonacciValues.Add(num, value);

            return value;
        }

        public static IEnumerable<long> FibonacciGenerator()
        {
            for (int i = 1; true; i++)
            {
                yield return NFibonacciNumber(i);
            }
        }
    }
}
