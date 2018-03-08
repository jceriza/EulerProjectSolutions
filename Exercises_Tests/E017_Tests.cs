using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E017_Tests
    {
        [Fact]
        public void Letters_1to5_19()
        {
            Assert.Equal(
                19,
                E017_Number_letter_counts.NumberOfLettersInSpelledNumbers(1, 5));
        }

        [Fact]
        public void Letters_1to1000_21124()
        {
            Assert.Equal(
                21124,
                E017_Number_letter_counts.NumberOfLettersInSpelledNumbers(1, 1000));
        }
    }
}
