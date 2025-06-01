public class Solution
{
    public long DistributeCandies(int n, int limit)
    {
        limit = Math.Min(limit, n);
        long result = 0;
        for (int i = 0; i <= limit; i++)
        {
            if (n - i > limit * 2) continue;
            result +=Math.Min(limit,n-i)-Math.Max(0, n - limit - i) + 1;
        }
        return result;
    }
}