using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public static class PandigitalNumber
    {
        private static List<int> MissingNumbers(int threshold, int number)
        {
            var numbers = Enumerable.Range(1, threshold).Reverse().ToList();

            while (number > 0)
            {
                numbers.Remove(number % 10);
                number /= 10;
            }

            return numbers;
        }

        private static int PandigitalHigherPrime(int threshold, int missing, int number)
        {
            if (missing == 0)
            {
                if (PrimeNumbers.IsPrimeNumber(number)) return number;

                return -1;
            }

            foreach (var n in MissingNumbers(threshold, number))
            {
                var result = PandigitalHigherPrime(threshold, missing - 1, number * 10 + n);

                if (result > -1) return result;
            }

            return -1;
        }

        private static bool IsPandigital(long number)
        {
            if (number < 10) return true;
            var numbers = new List<long>();

            while (number > 0)
            {
                var currentNumber = number % 10;
                if (currentNumber == 0 || numbers.Contains(currentNumber)) return false;
                numbers.Add(currentNumber);
                number /= 10;
            }

            return numbers.Distinct().Count() == numbers.Count();
        }

        private static long JoinNumbers(long a, long b)
        {
            var aux = b;

            while (aux > 0)
            {
                aux /= 10;
                a *= 10;
            }

            return a + b;
        }

        public static long ProductsSum()
        {
            var pandigitalProducts = new List<long>();
            var sum = 0;

            for (int a = 2; a <= 98; a++)
            {
                if (IsPandigital(a))
                {
                    var bInit = a < 10 ? 1234 : 123;
                    var bThreshold = a < 10 ? 9876 : 987;

                    for (int b = bInit; b <= bThreshold; b++)
                    {
                        var ab = JoinNumbers(a, b);

                        if (IsPandigital(ab))
                        {
                            var product = a * b;

                            if (IsPandigital(JoinNumbers(product, ab))
                                && !pandigitalProducts.Contains(product))
                            {
                                pandigitalProducts.Add(product);
                                sum += product;
                            }
                        }
                    }
                }
            }

            return sum;
        }

        public static List<long> PandigitalMultiples()
        {
            var pandigitals = new List<long>();

            for (long i = 1; i <= 9876; i++)
            {
                if (IsPandigital(i))
                {
                    var pandigitalNumber = i;

                    for (int j = 2; j < 10; j++)
                    {
                        pandigitalNumber = JoinNumbers(pandigitalNumber, i * j);

                        if (pandigitalNumber > 987_654_321 || !IsPandigital(pandigitalNumber)) break;

                        if (pandigitalNumber >= 123_456_789)
                        {
                            pandigitals.Add(pandigitalNumber);
                            break;
                        }
                    }
                }
            }

            return pandigitals;
        }

        public static int LargestPandigitalPrime()
        {
            var result = -1;

            for (int i = 9; i >= 1; i--)
            {
                result = PandigitalHigherPrime(i, i, 0);

                if (result > -1) return result;
            }

            return result;
        }
    }
}
