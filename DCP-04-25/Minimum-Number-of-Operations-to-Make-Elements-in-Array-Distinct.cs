public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        int n = nums.Length;
        int result = 0;
        Dictionary<int,int> dic = new Dictionary<int,int>();
        for (int i = n - 1; i >= 0; i--) {
            if (!dic.TryAdd(nums[i], 1))
            {
                result = i+1;
                result =(int)Math.Ceiling(result/ 3.0);
                break;
            }
        }
        return result;
    }
}