using Exercises;
using System.Collections.Generic;
using Xunit;

namespace Exercises_Tests
{
    public class E032_Tests
    {
        [Fact]
        public void PandigitalProductsSum()
        {
            Assert.Equal(
                45228,
                E032_Pandigital_products.ProductsSum());
        }
    }
}
