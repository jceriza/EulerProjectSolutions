using Utilities;

namespace Exercises
{
    public static class E024_Lexicographic_permutations
    {
        public static string OneMillionthLexicographicPermutation()
        {
            return new Permutations('0', '1', '2', '3', '4', '5', '6', '7', '8', '9')
                .NthPermutation(1_000_000);
        }
    }
}
