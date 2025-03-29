public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int min = prices[0];
        int result = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            min = Math.Min(prices[i], min);
            result = Math.Max(result,prices[i]-min);
        }
        return result;
    }
}