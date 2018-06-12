using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Exercises
{
    public static class E035_Circular_primes
    {
        private static IEnumerable<int> NumRotations(int num)
        {
            if (num < 10) yield return num;

            else
            {
                var nums = new Queue<int>();

                while (num > 0)
                {
                    var numToAdd = num % 10;
                    nums.Enqueue(num % 10);
                    num /= 10;
                }

                var i = 0;
                do
                {
                    var mult = 1;
                    var currentNumber = 0;
                    foreach (var number in nums)
                    {
                        currentNumber += number * mult;
                        mult *= 10;
                    }

                    yield return currentNumber;

                    nums.Enqueue(nums.Dequeue());
                } while (i++ < nums.Count - 1);
            }
        }

        public static int NumCircularPrimesBelowN(int n)
        {
            var circularPrimes = 0;

            for (int i = 0; i < n; i++)
            {
                if (NumRotations(i).All(rotation => PrimeNumbers.IsPrimeNumber(rotation)))
                {
                    circularPrimes++;
                }
            }

            return circularPrimes;
        }
    }
}
