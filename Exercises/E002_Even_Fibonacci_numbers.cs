using Utilities;

namespace Exercises
{
    public class E002_Even_Fibonacci_numbers
    {
        public static long EvenSumNotExceeding4Million()
        {
            ulong value = 0;
            ulong sum = 0;
            var fibonacci = new Fibonacci();

            for (int i = 1; value <= 4_000_000; i++)
            {
                value = fibonacci.Nth(i);
                if (value % 2 == 0) sum += value;
            }

            return long.Parse(sum.ToString());
        }
    }
}
