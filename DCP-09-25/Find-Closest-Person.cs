
        public class Solution
        {
            public int FindClosest(int x, int y, int z)
            {
                return Math.Abs(x - z) == Math.Abs(y - z) ? 0 : Math.Abs(x - z) > Math.Abs(y - z) ? 2:1;
            }
        }
