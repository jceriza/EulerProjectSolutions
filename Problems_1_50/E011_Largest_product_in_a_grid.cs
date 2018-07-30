namespace Exercises
{
    public class E011_Largest_product_in_a_grid
    {
        public static long LargestProductInASquaredGrid(int[,] grid, int nAdjacents)
        {
            int rowsAndCols = grid.GetUpperBound(0) + 1;
            long maxProduct = 0;

            for (int i = 0; i < rowsAndCols - nAdjacents; i++)
            {
                for (int j = 0; j < rowsAndCols - nAdjacents; j++)
                {
                    var currentHorizontalProduct = 1;
                    var currentVerticalProduct = 1;

                    for (int k = 0; k < nAdjacents; k++)
                    {
                        currentHorizontalProduct *= grid[i, j + k];
                        currentVerticalProduct *= grid[j + k, i];
                    }

                    if (currentHorizontalProduct > maxProduct) maxProduct = currentHorizontalProduct;
                    if (currentVerticalProduct > maxProduct) maxProduct = currentVerticalProduct;
                }
            }

            for (int i = nAdjacents - 1; i < rowsAndCols; i++)
            {
                for (int j = 0; j <= i - nAdjacents + 1; j++)
                {
                    var currentTopLeftDiagonalProduct = 1;
                    var currentTopRightDiagonalProduct = 1;

                    for (int k = 0; k < nAdjacents; k++)
                    {
                        currentTopLeftDiagonalProduct *= grid[i - k, j + k];
                        currentTopRightDiagonalProduct *= grid[i - k, rowsAndCols - 1 - j - k];
                    }

                    if (currentTopLeftDiagonalProduct > maxProduct) maxProduct = currentTopLeftDiagonalProduct;
                    if (currentTopRightDiagonalProduct > maxProduct) maxProduct = currentTopRightDiagonalProduct;
                }
            }

            return maxProduct;
        }
    }
}
