public class Solution
{
    public int MajorityElement(int[] nums)
    {
        return nums.GroupBy(x=>x).OrderByDescending(x=>x.Count()).First().Key;
    }
}