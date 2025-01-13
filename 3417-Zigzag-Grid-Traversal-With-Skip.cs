
        public class Solution
        {
            public IList<int> ZigzagTraversal(int[][] grid)
            {
                List<int> result = new List<int>();
                for (int i = 0; i < grid.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < grid[i].Length; j += 2)
                        {
                            result.Add(grid[i][j]);
                        }
                    }
                    else
                    {
                        int j;
                        if ((grid[i].Length % 2) == 0)  j = grid[i].Length - 1;
                        else j= grid[i].Length - 2;
                        for (; j >= 0; j -= 2)
                        {
                            result.Add(grid[i][j]);
                        }

                    }
                }
                return result;
            }
        }