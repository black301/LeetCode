public class Solution
{
    public string[] DivideString(string s, int k, char fill)
    {
        List<string> result = new List<string>();
        if (s.Length <= k)
        {
            result.Add(s.PadRight(k, fill));
        }
        else
        {
            for (int i = 0; i < s.Length; i += k)
            {
                result.Add(s.Substring(i, k));
                if (s.Length - (i + k) < k && s.Length % k != 0)
                {
                    string last = s.Substring(i + k, s.Length - (i + k));
                    result.Add(last.PadRight(k, fill));
                    break;
                }
            }
        }
       return result.ToArray();
    }
}