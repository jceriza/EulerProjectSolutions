using System.Linq;
using Utilities;

namespace Exercises
{
    public class E020_Factorial_digit_sum
    {
        public static int SumOfDigitsOfNumber(int num)
        {
            return LargeNumber
                .Factorial(num)
                .ToString()
                .Select(a => int.Parse(a.ToString()))
                .Sum();
        } 
    }
}
