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
            const int limit = 1_000_000;
            var nodes = new int[limit];
            nodes[1] = 1;
            var longestSeries = 0;
            var numberWithLongestSeries = 0;

            for (int i = 2; i < limit; i++)
            {
                long num = i;
                int currentSeries = 0;
                do
                {
                    currentSeries++;
                    num = CollatzNumber(num);

                    if (num < limit && nodes[num] > 0)
                    {
                        currentSeries += nodes[num];
                        nodes[i] = currentSeries;
                        
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
