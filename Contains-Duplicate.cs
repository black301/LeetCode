public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var result = nums.GroupBy(x => x).Where(x=>x.Count()>=2);
        return result.Count()>0;
    }
}