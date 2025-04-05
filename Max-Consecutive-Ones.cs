public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int temp = 0;
        foreach(var x in nums)
        {
            if (x == 1)
            {
                temp++;
            }
            else
            {
                temp = 0;
            }
            max=Math.Max(temp, max);
        }
        return max;
    }
}