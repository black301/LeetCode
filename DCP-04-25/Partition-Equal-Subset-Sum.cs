public class Solution
{
    public bool CanPartition(int[] nums)
    {
        long sum = nums.Sum();
        if (sum % 2 != 0) return false;
        sum /= 2;
        bool[] DP = new bool[sum+1];
        Array.Fill(DP, false);
        DP[0] = true;
        foreach (var num in nums){
            for (long i = sum; i >= num; i--)
            {
                DP[i]=DP[i]||DP[i-num];
                if (DP[sum])return true;
            }
        }
        return DP[sum];
    }
}