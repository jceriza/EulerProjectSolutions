using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Utilities
{
    public static class Fibonacci
    {
        private static readonly ConcurrentDictionary<int, string> _fibonacciValues
            = new ConcurrentDictionary<int, string>();

        static Fibonacci()
        {
            _fibonacciValues.TryAdd(1, "1");
            _fibonacciValues.TryAdd(2, "1");
        }

        public static string NthFibonacciNumber(int num)
        {
            if (_fibonacciValues.TryGetValue(num, out string value))
            {
                return value;
            }

            value = LargeNumbersCalculations.Sum(NthFibonacciNumber(num - 1), NthFibonacciNumber(num - 2));

            _fibonacciValues.TryAdd(num, value);

            return value;
        }

        public static IEnumerable<string> FibonacciGenerator()
        {
            for (int i = 1; true; i++)
            {
                yield return NthFibonacciNumber(i);
            }
        }
    }
}
