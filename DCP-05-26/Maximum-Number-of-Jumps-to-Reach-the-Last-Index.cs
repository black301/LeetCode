1public class Solution
2{
3    public int MaximumJumps(int[] nums, int target)
4    {
5        int[] db = new int[nums.Length];
6        int max = 0;
7        db[nums.Length - 1] = 1;
8        for (int i = nums.Length-2 ; i >= 0; i--)
9        {
10            max = 0;
11            for (int j = i+1 ; j < nums.Length; j++){
12                if (Math.Abs(nums[i] - nums[j]) <= target)
13                {
14                    if (db[j]!=0)
15                        max = Math.Max(max, db[j]+1);    
16                }
17            }
18            db[i] = max;
19        }
20        return db[0]==0?-1: db[0]-1;
21    }
22}