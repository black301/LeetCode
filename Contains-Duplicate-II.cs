public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
       Dictionary<int ,int > dict = new Dictionary<int ,int>();
        for (int i = 0; i < nums.Length; i++) {
            if (!dict.TryAdd(nums[i],i))
            {
                if (Math.Abs(dict[nums[i]]-i)<=k) return true;
                else dict[nums[i]] = i;
            }
        }
        return false;
    }
}