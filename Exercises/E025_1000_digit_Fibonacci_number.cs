using Utilities;

namespace Exercises
{
    public static class E025_1000_digit_Fibonacci_number
    {
        public static int IndexOf1000DigitFibonacciNumber()
        {
            var i = 1;
            for (; Fibonacci.NthFibonacciNumber(i).Length < 1000; i++) ;

            return i;
        }
    }
}
