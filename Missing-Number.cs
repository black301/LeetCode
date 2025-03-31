public class Solution
{
    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);
        int x = 0;
        foreach (var num in nums)
        {
            if(x!=num) return x;
            x++;
        }
        return x;
    }
}