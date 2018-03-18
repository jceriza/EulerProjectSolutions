using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E022_Tests
    {
        [Fact]
        public void NameScoresTest()
        {
            Assert.Equal(
                871198282,
                E022_Name_scores.NamesScore());
        }
    }
}
