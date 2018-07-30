using Utilities;

namespace Exercises
{
    public class E015_Lattice_Paths
    {
        public static long LatticePathsInANxNGrid(int n)
        {
            var nominator = new LargeNumber(1);

            for (int i = 2 * n - 1; i > n; i--)
                nominator *= i;

            var denominator = LargeNumber.Factorial(n - 1);

            return long.Parse((nominator / denominator).ToString()) * 2;
        }
    }
}
