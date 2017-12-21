using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E9_Tests
    {
        [Fact]
        public void SpecialPythagoreanTriplet_60()
        {
            var pythagoreanProduct = E9_Special_Pythagorean_triplet.PythagoreanProduct(12);

            Assert.Equal(60, pythagoreanProduct);
        }

        [Fact]
        public void SpecialPythagoreanTriplet_31875000()
        {
            var pythagoreanProduct = E9_Special_Pythagorean_triplet.PythagoreanProduct(1000);

            Assert.Equal(31875000, pythagoreanProduct);
        }
    }
}
