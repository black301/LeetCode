public class Solution
{
    public bool DigitCount(string num)
    {
        int[] ints = new int[10];
        foreach(char c in num)
        {
            ints[c - '0']++;
        }
        for(int i=0;i<num.Length; i++)
        {
            if (ints[i] != num[i] - '0')
            {
                return false;
            }
        }
        return true;
    }
}