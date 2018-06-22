using System.Collections.Generic;

namespace Exercises
{
    public class E043_Substring_divisibility
    {
        private static bool IsSubstringDivisibilityFeasible(long number)
        {
            if (number < 1_000) return true;
            if (number < 10_000) return (number % 1_000) % 2 == 0;
            if (number < 100_000) return (number % 1_000) % 3 == 0;
            if (number < 1_000_000) return (number % 1_000) % 5 == 0;
            if (number < 10_000_000) return (number % 1_000) % 7 == 0;
            if (number < 100_000_000) return (number % 1_000) % 11 == 0;
            if (number < 1_000_000_000) return (number % 1_000) % 13 == 0;
            return (number % 1_000) % 17 == 0;
        }

        public static long PandigitalSubstringDivisibility(List<int> missing, long number)
        {
            if (!IsSubstringDivisibilityFeasible(number)) return 0;
            if (number > 987654321) return number;

            var result = 0L;

            for (int i = 0; i < missing.Count; i++)
            {
                var n = missing[i];
                missing.RemoveAt(i);

                result += PandigitalSubstringDivisibility(
                    missing,
                    number * 10 + n);

                missing.Insert(i, n);
            }

            return result;
        }

        public static long SubstringDivisibility()
        {
            return PandigitalSubstringDivisibility(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0);
        }
    }
}
