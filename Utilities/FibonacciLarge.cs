using System.Collections.Generic;

namespace Utilities
{
    public class FibonacciLarge
    {
        private readonly Dictionary<int, LargeNumber> _fibonacciValues
            = new Dictionary<int, LargeNumber>();

        public FibonacciLarge()
        {
            _fibonacciValues.Add(1, new LargeNumber(1));
            _fibonacciValues.Add(2, new LargeNumber(1));
        }

        public LargeNumber Nth(int num)
        {
            if (_fibonacciValues.TryGetValue(num, out LargeNumber value))
            {
                return value;
            }

            value = Nth(num - 1) + Nth(num - 2);

            _fibonacciValues.Add(num, value);

            return value;
        }
    }
}
