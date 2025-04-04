public class Solution
{
    public int IslandPerimeter(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    return CalculatePerimeter(grid, i, j);
                }
            }
        }
        return 0;
    }
    public int CalculatePerimeter(int[][] grid, int i, int j)
    {
        if (i < 0 ||
            j < 0 || 
            i >= grid.Length ||
            j >= grid[i].Length ||
            grid[i][j] == 0)
        {
            return 1;
        }
        if (grid[i][j] == -1)
        {
            return 0;
        }
        grid[i][j] =-1;
        return CalculatePerimeter(grid, i - 1, j) +
                   CalculatePerimeter(grid, i + 1, j) +
                   CalculatePerimeter(grid, i, j + 1) +
                   CalculatePerimeter(grid, i, j - 1);
    }
}