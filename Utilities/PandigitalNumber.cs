using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public static class PandigitalNumber
    {
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
    }
}
