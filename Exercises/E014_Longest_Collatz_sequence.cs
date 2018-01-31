using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class E014_Longest_Collatz_sequence
    {
        private static Dictionary<long, long> nodes = new Dictionary<long, long> { { 1, 1 } };

        public static long LongestSeriesUnderOneMillion()
        {
            long maxLength = 0;
            long numberWithMaxLength = 1;

            for (long i = 2; i < 1_000_000; i++)
            {
                var currentNode = i;
                var queue = new Queue<long>();

                while (!nodes.ContainsKey(currentNode))
                {
                    queue.Enqueue(currentNode);

                    if (currentNode % 2 == 0) currentNode /= 2;
                    else currentNode = 3 * currentNode + 1;
                }

                var currentNodeDepth = nodes[currentNode];

                while (queue.Any())
                {
                    var totalDepth = queue.Count + currentNodeDepth;
                    var value = queue.Dequeue();

                    nodes[value] = totalDepth;
                }

                if (nodes[i] > maxLength)
                {
                    numberWithMaxLength = i;
                    maxLength = nodes[i];
                }
            }

            return numberWithMaxLength;
        }
    }
}
