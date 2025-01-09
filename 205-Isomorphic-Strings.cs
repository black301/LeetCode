public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char,char> dicS = new Dictionary<char, char>();
        string result = \\;
        for(int i = 0; i < s.Length; i++)
        {
            if (!dicS.ContainsKey(s[i]) && !dicS.ContainsValue(t[i]))
                dicS.Add(s[i], t[i]);
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (dicS.ContainsKey(s[i]))
            result = result + dicS[s[i]];   
        }

        return result==t;
    }
}