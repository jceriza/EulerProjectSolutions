using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E030_Digit_fifth_powers
    {
        public static int SumNthPowersOfTheirDigits(int n)
        {
            return new DigitPowers(n).GetPowers().Sum();
        }
    }
}
