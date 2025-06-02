public class Solution
{
    public int Candy(int[] ratings)
    {
        int[] dp = new int[ratings.Length];
        Array.Fill(dp, 1);
        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                dp[i] = dp[i - 1] + 1;
            }
        }
        for (int i = ratings.Length-2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1] && dp[i] <= dp[i+1])
            {
                dp[i] = dp[i+1] + 1;
            }
        }
        return dp.Sum();
    }
}