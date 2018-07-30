using System.Collections.Generic;
using Utilities;

namespace Exercises
{
    public class E029_Distinct_powers
    {
        public static HashSet<string> Sequence(int from, int to)
        {
            var sequence = new HashSet<string>();

            for (int a = from; a <= to; a++)
            {
                var aLargeNumber = new LargeNumber(a);
                var aggregate = new LargeNumber(a);

                for (int i = 1; i < from; i++)
                {
                    aggregate *= aLargeNumber;
                }

                sequence.Add(aggregate.ToString());

                for (int b = from + 1; b <= to; b++)
                {
                    aggregate *= aLargeNumber;
                    sequence.Add(aggregate.ToString());
                }
            }

            return sequence;
        }
    }
}
