using System.Text;

namespace Utilities
{
    public static class LargeNumbersCalculations
    {
        public static string Sum(string accrued, string second)
        {
            var sum = new StringBuilder();
            var carriage = 0;
            var longest = accrued.Length > second.Length ? accrued : second;
            var shortest = accrued.Length <= second.Length ? accrued : second;

            for (int i = longest.Length - 1, j = shortest.Length - 1; i >= 0; i--, j--)
            {
                var firstCharacter = int.Parse(longest[i].ToString());
                var secondCharacter = j >= 0 ? int.Parse(shortest[j].ToString()) : 0;

                var currentSum = firstCharacter + secondCharacter + carriage;

                if (currentSum > 9) carriage = currentSum / 10;
                else carriage = 0;

                sum.Insert(0, currentSum % 10);
            }

            if (carriage > 0) sum.Insert(0, carriage);

            return sum.ToString();
        }

        public static string Multiplication(string accrued, string second)
        {
            var longest = accrued.Length > second.Length ? accrued : second;
            var shortest = accrued.Length <= second.Length ? accrued : second;

            var accruedMultiplication = "0";

            for (int i = shortest.Length - 1, zeroesToAdd = 0; i >= 0; i--, zeroesToAdd++)
            {
                var carriage = 0;
                var shortestNum = int.Parse(shortest[i].ToString());
                var currentMultiplication = new StringBuilder(new string('0', zeroesToAdd));

                for (int j = longest.Length - 1; j >= 0; j--)
                {
                    var longestNum = int.Parse(longest[j].ToString());
                    var mult = shortestNum * longestNum + carriage;
                    var numToAdd = mult % 10;
                    carriage = mult / 10;                    

                    currentMultiplication.Insert(0, numToAdd);
                }

                if (carriage > 0) currentMultiplication.Insert(0, carriage);

                accruedMultiplication = Sum(accruedMultiplication, currentMultiplication.ToString());
            }

            return accruedMultiplication;
        }

        public static string Factorial(int number)
        {
            if (number == 1)
            {
                return "1";
            }

            return Multiplication(number.ToString(), Factorial(number - 1));
        }
    }
}
