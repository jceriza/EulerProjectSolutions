using Utilities;
using Xunit;

namespace Utilities_Tests
{
    public class SpellNumbersTests
    {
        [Fact]
        public void SpellNumbers_342()
        {
            Assert.Equal(
                "three hundred and forty two",
                SpellNumbers.Spell(342));
        }

        [Fact]
        public void SpellNumbers_115()
        {
            Assert.Equal(
                "one hundred and fifteen",
                SpellNumbers.Spell(115));
        }

        [Fact]
        public void SpellNumbers_901()
        {
            Assert.Equal(
                "nine hundred and one",
                SpellNumbers.Spell(901));
        }
    }
}
