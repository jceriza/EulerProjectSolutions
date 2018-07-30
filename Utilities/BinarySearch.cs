using System.Collections.Generic;

namespace Utilities
{
    public static class BinarySearch
    {
        public static bool ContainsWithBinarySearch(this List<long> list, long num)
        {
            var left = 0;
            var right = list.Count - 1;

            while (left <= right)
            {
                var medium = (left + right) / 2;

                if (list[medium] < num) left = medium + 1;
                else if (list[medium] > num) right = medium - 1;
                else return true;
            }

            return false;
        }
    }
}
