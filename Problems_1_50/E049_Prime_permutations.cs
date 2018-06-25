using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Exercises
{
    public class E049_Prime_permutations
    {
        public static int OrderedNum(int number)
        {
            var numbers = new List<int>();

            while (number > 0)
            {
                var currentNumber = number % 10;
                numbers.Add(currentNumber);
                number /= 10;
            }

            numbers = numbers.OrderBy(a => a).ToList();

            int num = 0;

            for (int i = 0; i < numbers.Count; i++)
                num = num * 10 + numbers[i];

            return num;
        }

        public static long PrimePermutations()
        {
            var primesWith4Numbers = new List<(long num, int orderedNum)>();

            for (int i = 1235; i <= 9875; i += 2)
                if (PrimeNumbers.IsPrimeNumber(i))
                    primesWith4Numbers.Add((i, OrderedNum(i)));            

            for (int i = 0; i < primesWith4Numbers.Count; i++)
            {
                var (firstNum, firstOrderedNum) = primesWith4Numbers[i];

                for (int j = i + 1; j < primesWith4Numbers.Count; j++)
                {
                    if (firstOrderedNum == primesWith4Numbers[j].orderedNum)
                    {
                        var (secondNum, secondOrderedNum) = primesWith4Numbers[j];
                        var firstDiff = secondNum - firstNum;

                        for (int k = j + 1; k < primesWith4Numbers.Count; k++)
                        {
                            var (thirdNum, thirdOrderedNum) = primesWith4Numbers[k];
                            var lastDiff = thirdNum - secondNum;

                            if (lastDiff > firstDiff) break;

                            if (lastDiff == firstDiff && thirdOrderedNum == firstOrderedNum)
                            {
                                var joinedNumbers = firstNum.JoinWith(secondNum.JoinWith(thirdNum));

                                if (joinedNumbers != 148748178147) return joinedNumbers;
                            }
                        }
                    }
                }
            }

            return 0;
        }
    }
}
