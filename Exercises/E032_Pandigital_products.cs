using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E032_Pandigital_products
    {
        private static bool IsPandigital(long number)
        {
            if (number < 10) return true;
            var numbers = new List<long>();
            while (number > 0)
            {
                var currentNumber = number % 10;
                if (currentNumber == 0) return false;
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
    }
}
