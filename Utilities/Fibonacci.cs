using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Utilities
{
    public static class Fibonacci
    {
        private static readonly ConcurrentDictionary<int, LargeNumber> _fibonacciValues
            = new ConcurrentDictionary<int, LargeNumber>();

        static Fibonacci()
        {
            _fibonacciValues.TryAdd(1, new LargeNumber(1));
            _fibonacciValues.TryAdd(2, new LargeNumber(1));
        }

        public static LargeNumber NthFibonacciNumber(int num)
        {
            if (_fibonacciValues.TryGetValue(num, out LargeNumber value))
            {
                return value;
            }

            value = NthFibonacciNumber(num - 1) + NthFibonacciNumber(num - 2);

            _fibonacciValues.TryAdd(num, value);

            return value;
        }

        public static IEnumerable<LargeNumber> FibonacciGenerator()
        {
            for (int i = 1; true; i++)
            {
                yield return NthFibonacciNumber(i);
            }
        }
    }
}
