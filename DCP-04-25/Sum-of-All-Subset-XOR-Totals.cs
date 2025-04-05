public class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        int n = nums.Length;
        int y;
        int sum = 0;
        List<int> XOR = new List<int>();
        for(int i = n-1; i >= 0; i--)
        {
            XOR.Add(nums[i]);
            y = XOR.Count;
            for(int j = 0; j < y-1; j++)
            {
                XOR.Add(nums[i] ^ XOR[j]);
            }
        }
        return XOR.Sum();
    }
}