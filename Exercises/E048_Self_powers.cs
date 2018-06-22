using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Exercises
{
    public static class E048_Self_powers
    {
        public static LargeNumber SelfPowerSeriesSumUntilN(int n)
        {
            var sum = new LargeNumber(0);

            for (int i = 1; i <= n; i++)
            {
                sum += LargeNumber.Pow(i, i);
            }

            return sum;
        }
    }
}
