public class Solution
{
    public int CountSymmetricIntegers(int low, int high)
    {
        int count = 0;
        for (int i = low; i <= high; i++)
        {
            string s = i.ToString();
            int n = s.Length;
            if (n % 2== 0)
            {
                if(s.Substring(n / 2, n / 2).Sum(c =>c)==
                   s.Substring(0, n / 2).Sum(c => c)){
                    count++;
                }
            }
        }
        return count;
    }
}