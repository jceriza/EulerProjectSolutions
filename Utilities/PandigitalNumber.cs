using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public static class PandigitalNumber
    {
        private static List<int> MissingNumbers(int threshold, long number, bool addZero)
        {
            var addInitialZero = addZero && number > 0;

            var numbers = Enumerable
                .Range(addInitialZero ? 0 : 1, addInitialZero ? threshold : threshold - 1)
                .Reverse()
                .ToList();

            while (number > 0)
            {
                numbers.Remove((int)(number % 10));
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

            foreach (var n in MissingNumbers(threshold, number, false))
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

        public static bool IsSubstringDivisibilityFeasible(long number)
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

        public static long PandigitalSubstringDivisibility(int threshold, int missing, long number)
        {
            if (!IsSubstringDivisibilityFeasible(number)) return 0;
            if (missing == 0) return number;

            var result = 0L;

            foreach (var n in MissingNumbers(10, number, true))
            {
                result += PandigitalSubstringDivisibility(threshold, missing - 1, number * 10 + n);
            }

            return result;
        }
    }
}
