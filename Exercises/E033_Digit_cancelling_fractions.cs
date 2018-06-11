using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Exercises
{
    public static class E033_Digit_cancelling_fractions
    {
        public static int DenominatorProductFractions()
        {
            var (multNumerator, multDenominator) = (1, 1);

            for (int numerator = 10; numerator < 100; numerator++)
            {
                var nLeft = numerator % 10;
                var nRight = numerator / 10;

                for (int denominator = numerator + 1; denominator < 100; denominator++)
                {
                    if (numerator % 10 == 0 && denominator % 10 == 0) continue;

                    var fraction = numerator / (double)denominator;
                    
                    var dLeft = denominator % 10;
                    var dRight = denominator / 10;
                    int a = -1, b = -1;

                    if (nLeft == dLeft) (a, b) = (nRight, dRight);
                    else if (nLeft == dRight) (a, b) = (nRight, dLeft);
                    else if (nRight == dLeft) (a, b) = (nLeft, dRight);
                    else if (nRight == dRight) (a, b) = (nLeft, dLeft);

                    if (a < b && fraction == a / (double)b)
                    {
                        multNumerator *= a;
                        multDenominator *= b;
                    }
                }
            }

            return (int)Divisors.LowestCommonTerms(multNumerator, multDenominator).denominator;
        }
    }
}
