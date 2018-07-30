using System.Linq;
using Utilities;

namespace Exercises
{
    public class E013_Large_sum
    {
        public static string FirstTenDigitsOf50NumbersSum(string numbers)
        {
            var numbersList = numbers
                .Replace("\r", "")
                .Split('\n')
                .Select(n => new LargeNumber(n))
                .ToList();

            var totalSum = numbersList[0];

            for (int i = 1; i < numbersList.Count; i++)
            {
                totalSum += numbersList[i];
            }

            return totalSum.ToString().Substring(0, 10);
        }
    }
}
