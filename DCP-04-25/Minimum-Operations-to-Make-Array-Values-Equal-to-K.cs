public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        int max = nums.Max();
        int min = nums.Min();
        if (k > min) return -1;
        if (k == min)  return nums.Distinct().Count()-1;
        return nums.Distinct().Count();

    }
}