using Utilities;

namespace Exercises
{
    public static class E018_Maximum_path_sum
    {
        public static int MaximumPathSum(string triangle)
        {
            return new TriangleTree(triangle).MaximumPathSum();
        }
    }
}
