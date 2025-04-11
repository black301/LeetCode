public class Solution
{
    public long NumberOfPowerfulInt(long start, long finish, int limit, string s)
    {
        string upperLimit = finish.ToString();
        string lowerLimit = (start - 1).ToString();
        long lowerLimitLenght = lowerLimit.Length;
        long upperLimitLenght = upperLimit.Length;
        long lowerCount = 0, upperCount = 0;
        long suffixLenght = s.Length;
        long[][] DP = new long[upperLimitLenght][];
        if (suffixLenght <= upperLimitLenght)
        {
            for (int i = 0; i < upperLimitLenght; i++)
            {
                DP[i] = new long[2];
                Array.Fill(DP[i], -1);
            }
            upperCount = I_HATE_DIGIT_DP(0, DP, upperLimit, s, 1, limit); ;
        }
        if (suffixLenght <= lowerLimitLenght)
        {
            for (int i = 0; i < upperLimitLenght; i++)
            {
                DP[i] = new long[2];
                Array.Fill(DP[i], -1);
            }
            lowerCount = I_HATE_DIGIT_DP(0, DP, lowerLimit, s, 1, limit);
        }
        return upperCount - lowerCount;
    }
    public long I_HATE_DIGIT_DP(int idx, long[][] dp, string MaxNumber, string suffix, int tight, int limit)
    {
        if (idx == MaxNumber.Length) return 1;
        if (dp[idx][tight] != -1) return dp[idx][tight];
        long upperLimit = (tight == 1) ? Math.Min(limit, MaxNumber[idx] - '0') : limit;
        long lowerLimit = 0, count = 0;
        long suffixStartIndex = MaxNumber.Length - suffix.Length;
        if (suffixStartIndex <= idx)
        {
            lowerLimit = suffix[(int)(idx - suffixStartIndex)] - '0';
            upperLimit = Math.Min(lowerLimit, upperLimit);
        }
        for (int i = (int)lowerLimit; i <= upperLimit; i++)
        {
            int  newtight = (tight == 1 && i == MaxNumber[idx] - '0') ? 1 : 0;
            count += I_HATE_DIGIT_DP(idx + 1, dp, MaxNumber, suffix, newtight, limit);
        }
        dp[idx][tight] = count;
        return count;

    }
}