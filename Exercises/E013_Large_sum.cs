using Utilities;

namespace Exercises
{
    public static class E013_Large_sum
    {
        public static string FirstTenDigitsOf50NumbersSum(string numbers)
        {
            var numbersList = numbers.Replace("\r", "").Split('\n');
            var totalSum = numbersList[0];

            for (int i = 1; i < numbersList.Length; i++)
            {
                totalSum = LargeNumbersCalculations.Sum(totalSum, numbersList[i]);
            }

            return totalSum.Substring(0, 10);
        }
    }
}
