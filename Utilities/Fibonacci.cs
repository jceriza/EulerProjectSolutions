using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Utilities
{
    public class Fibonacci
    {
        private readonly Dictionary<int, ulong> _fibonacci =
            new Dictionary<int, ulong>();

        public Fibonacci()
        {
            _fibonacci.Add(1, 1);
            _fibonacci.Add(2, 1);
        }

        public ulong Nth(int num)
        {
            if (_fibonacci.TryGetValue(num, out ulong value))
            {
                return value;
            }

            value = Nth(num - 1) + Nth(num - 2);

            _fibonacci.Add(num, value);

            return value;
        }
    }
}
