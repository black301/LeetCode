public class Solution
{
    public int DivisorSubstrings(int num, int k)
    {
        string result = num.ToString();
        int count = 0;
        for (int i = 0; i <= result.Length - k; i++)
        {
            string temp = result.Substring(i,k);
            long temp2 = int.Parse(temp);
            if ( temp2 != 0 && num%temp2==0)
            {
                count++;
            }
        }
        
        return count;
    }
}