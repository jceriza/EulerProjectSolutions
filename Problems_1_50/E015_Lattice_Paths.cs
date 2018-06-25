using Utilities;

namespace Exercises
{
    public static class E015_Lattice_Paths
    {
        public static long LatticePathsInANxNGrid(int n)
        {
            var a = LargeNumber.Factorial(2 * n - 1);
            var b = LargeNumber.Factorial(n) * LargeNumber.Factorial(n - 1);

            return long.Parse((a / b).ToString()) * 2;
        }
    }
}
