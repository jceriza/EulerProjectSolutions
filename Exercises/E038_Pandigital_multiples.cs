using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E038_Pandigital_multiples
    {
        public static long LargestPandigitalFormedWithMultiples()
        {
            var pandigitals = new List<long>();

            for (long i = 1; i <= 9876; i++)
            {
                if (PandigitalNumber.IsPandigital(i))
                {
                    var pandigitalNumber = i;

                    for (int j = 2; j < 10; j++)
                    {
                        pandigitalNumber = pandigitalNumber.JoinWith(i * j);

                        if (pandigitalNumber > 987_654_321
                            || !PandigitalNumber.IsPandigital(pandigitalNumber)) break;

                        if (pandigitalNumber >= 123_456_789)
                        {
                            pandigitals.Add(pandigitalNumber);
                            break;
                        }
                    }
                }
            }

            return pandigitals.Max();
        }
    }
}
