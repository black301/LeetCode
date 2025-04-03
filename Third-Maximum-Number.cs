public class Solution
{
    public int ThirdMax(int[] nums)
    {
       int[] result = nums.Distinct().OrderByDescending(x => x).ToArray();
        if (result.Length < 3)
        {
            return result[0];
        }
        else
        {
            return result[2];
        }
    }
}