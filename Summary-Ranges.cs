public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        string result = "";
        IList<string> ranges = new List<string>();
        if(nums.Length==0)return ranges;
        int l = nums[0];
        int r = nums[0] - 1;
        foreach (var x in nums)
        {
            if (x == r + 1) r = x;
            else
            {
                if (l != r)
                    result = $"{l}->{r}";
                else result = $"{l}";
                ranges.Add(result);
                l = x;
                r = x;
            }
        }
        if (l != r)
            result = $"{l}->{r}";
        else result = $"{l}";
        ranges.Add(result);
        return ranges;
    }
}