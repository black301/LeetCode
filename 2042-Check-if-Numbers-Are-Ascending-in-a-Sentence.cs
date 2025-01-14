public class Solution
{
    public bool AreNumbersAscending(string s)
    {
        int x = 0,temp;
        for (int i=0;i<s.Length;i++) {
            if (i<s.Length-2 && int.TryParse($"{s[i]}{s[i + 1]}{s[i + 2]}",out temp))
            {
                if (x >= temp) return false;
                x=temp;
                i += 2;
            }else if (i<s.Length-1 && int.TryParse($"{s[i]}{s[i + 1]}", out temp))
            {
                if (x >= temp) return false;
                x = temp;
                i++;
            }else if (int.TryParse($"{s[i]}", out temp))
            {
                if (x >= temp) return false;
                x = temp;
            }
        }
        return true;
    }
}