using System.Collections.Generic;

namespace Exercises
{
    public class E014_Longest_Collatz_sequence
    {
        private static long CollatzNumber(long num)
        {
            if (num % 2 == 0) return num / 2;
            return num * 3 + 1;
        }

        public static int LongestSeriesUnderOneMillion()
        {
            var nodes = new Dictionary<long, int> { { 1, 1 } };
            var longestSeries = 0;
            var numberWithLongestSeries = 0;

            for (int i = 2; i < 1_000_000; i++)
            {
                long num = i;
                int currentSeries = 0;
                do
                {
                    currentSeries++;
                    num = CollatzNumber(num);

                    if (nodes.TryGetValue(num, out int numSeries))
                    {
                        currentSeries += numSeries;
                        nodes.Add(i, currentSeries);
                        
                        if (currentSeries > longestSeries)
                        {
                            longestSeries = currentSeries;
                            numberWithLongestSeries = i;
                        }

                        break;
                    }
                } while (num > 1);
            }

            return numberWithLongestSeries;
        }
    }
}
