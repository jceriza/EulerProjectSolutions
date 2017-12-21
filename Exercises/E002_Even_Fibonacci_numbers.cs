using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E002_Even_Fibonacci_numbers
    {
        public static long EvenSumNotExceeding4Million()
        {
            int i = 1;
            long value = Fibonacci.FibonacciGenerator().First();
            long sum = 0;

            while (value <= 4000000)
            {
                if (value % 2 == 0) sum += value;

                value = Fibonacci.FibonacciGenerator().Skip(i++).First();
            }

            return sum;
        }
    }
}
