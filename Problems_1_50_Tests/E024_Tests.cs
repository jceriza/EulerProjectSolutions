using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E024_Tests
    {
        [Fact]
        public void OneMillionthLexicographicPermutation()
        {
            Assert.Equal(
                "2783915460",
                E024_Lexicographic_permutations.OneMillionthLexicographicPermutation());
        }
    }
}
