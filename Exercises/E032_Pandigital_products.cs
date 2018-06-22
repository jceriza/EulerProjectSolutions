using System.Collections.Generic;
using Utilities;

namespace Exercises
{
    public static class E032_Pandigital_products
    {
        public static long ProductsSum()
        {
            var pandigitalProducts = new List<long>();
            long sum = 0;

            for (long a = 2; a <= 98; a++)
            {
                if (PandigitalNumber.IsPandigital(a))
                {
                    var bInit = a < 10 ? 1234 : 123;
                    var bThreshold = a < 10 ? 9876 : 987;

                    for (long b = bInit; b <= bThreshold; b++)
                    {
                        var ab = a.JoinWith(b);

                        if (PandigitalNumber.IsPandigital(ab))
                        {
                            var product = a * b;

                            if (PandigitalNumber.IsPandigital(product.JoinWith(ab))
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
