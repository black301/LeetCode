
        public class Solution
        {
            public int CountPoints(string rings)
            {
                int[,] bars = new int[10,3];
                for(int i=0;i<rings.Length;i+=2)
                {
                    if (rings[i] == 'R') bars[rings[i + 1] - '0', 0]++;
                    else if (rings[i] =='G') bars[rings[i + 1] - '0', 1]++;
                    else if (rings[i] =='B') bars[rings[i + 1]-'0', 2]++;
                }
                int count = 0;
                for (int i = 0; i < 10; i ++)
                {
                    if(bars[i, 0] > 0 && bars[i, 1] > 0 && bars[i, 2] > 0) count++;
                }
                return count;
            }
        }