using System.Text;

namespace Exercises
{
    public static class E013_Large_sum
    {
        private static string TwoLargeNumbersSum(string accrued, string second)
        {
            var sum = new StringBuilder();
            var carriage = 0;

            for (int i = accrued.Length - 1, j = second.Length - 1; i >= 0; i--, j--)
            {
                var firstCharacter = int.Parse(accrued[i].ToString());
                var secondCharacter = j >= 0 ? int.Parse(second[j].ToString()) : 0;

                var currentSum = firstCharacter + secondCharacter + carriage;

                if (currentSum > 9) carriage = currentSum / 10;
                else carriage = 0;

                sum.Insert(0, currentSum % 10);
            }

            if (carriage > 0) sum.Insert(0, carriage);

            return sum.ToString();
        }

        public static string FirstTenDigitsOf50NumbersSum(string numbers)
        {
            var numbersList = numbers.Replace("\r", "").Split('\n');
            var totalSum = numbersList[0];

            for (int i = 1; i < numbersList.Length; i++)
            {
                totalSum = TwoLargeNumbersSum(totalSum, numbersList[i]);
            }

            return totalSum.Substring(0, 10);
        }
    }
}
