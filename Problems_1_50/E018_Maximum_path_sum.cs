using Utilities;

namespace Exercises
{
    public class E018_Maximum_path_sum
    {
        public static int MaximumPathSum(string triangle)
        {
            return new TriangleTree(triangle).MaximumPathSum();
        }
    }
}
