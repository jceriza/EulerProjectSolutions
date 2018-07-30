using Utilities;

namespace Exercises
{
    public class E025_1000_digit_Fibonacci_number
    {
        public static int IndexOf1000DigitFibonacciNumber()
        {
            var fibonacci = new FibonacciLarge();

            var i = 1;
            for (; fibonacci.Nth(i).Length < 1000; i++) ;

            return i;
        }
    }
}
