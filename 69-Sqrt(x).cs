public class Solution
{
    public int MySqrt(int x)
    {
        if (x==0) return 0;
        for (long i = 0; i < x; i++)
        {
            if (i * i > x)
            {
                return (int)i-1;
            }
            if (i * i == x)
            {
                return (int)i;
            }
        }
            return 1;
    }
}