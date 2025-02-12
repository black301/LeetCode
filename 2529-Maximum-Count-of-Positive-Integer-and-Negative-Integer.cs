
        public class Solution
        {
            public int MaximumCount(int[] nums)
            {
                int l = 0;
                int r = nums.Length;
                while (l < r)
                {
                    int mid = (l + r) >> 1;
                    if (nums[mid] >= 0) r = mid;
                    else l = mid + 1;
                }
                int max = l;
                l = 0;
                r = nums.Length;
                while (l < r)
                {
                    int mid = (l + r) >> 1;
                    if (nums[mid] > 0) r = mid;
                    else l = mid+1;
                }
                return Math.Max(nums.Length-l, max);
            }
        }