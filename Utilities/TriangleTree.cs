using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public class TriangleTree : BinaryTree<int>
    {
        private List<int> _sumList;

        public TriangleTree(string triangle) : base(BuildTriangle(triangle))
        {
        }

        private static BinaryTreeNode<int> BuildTriangle(string triangle)
        {
            var splittedTriangle = triangle
                .Replace("\r", "")
                .Split('\n')
                .Reverse()
                .Select(l => l.Split(' ').Select(n => int.Parse(n)).ToList());

            List<BinaryTreeNode<int>> binaryTrees = null;

            foreach (var triangleFloor in splittedTriangle)
            {
                if (binaryTrees == null)
                {
                    binaryTrees = triangleFloor
                        .Select(n => new BinaryTreeNode<int>(n))
                        .ToList();
                }
                else
                {
                    var builtBinaryTrees = new List<BinaryTreeNode<int>>();

                    for (int i = 0; i < triangleFloor.Count; i++)
                    {
                        builtBinaryTrees.Add(
                            new BinaryTreeNode<int>(
                                triangleFloor[i], binaryTrees[i], binaryTrees[i + 1]));
                    }

                    binaryTrees = builtBinaryTrees;
                }
            }

            return binaryTrees.Single();
        }

        private int CalculateSumPaths()
        {
            _sumList = new List<int>();

            PathSum(Root, 0);

            return _sumList.Max();
        }

        private void PathSum(BinaryTreeNode<int> triangle, int accrued)
        {
            var currentSum = accrued + triangle.Value;

            if (triangle.Left == null && triangle.Right == null)
            {
                _sumList.Add(currentSum);
            }
            else
            {
                PathSum(triangle.Left, currentSum);
                PathSum(triangle.Right, currentSum);
            }
        }

        public int MaximumPathSum()
        {
            return CalculateSumPaths();
        }
    }
}
