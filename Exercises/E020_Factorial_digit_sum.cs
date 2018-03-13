using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E020_Factorial_digit_sum
    {
        public static int SumOfDigitsOfNumber(int num)
        {
            return LargeNumbersCalculations
                .Factorial(num)
                .Select(a => int.Parse(a.ToString()))
                .Sum();
        } 
    }
}
