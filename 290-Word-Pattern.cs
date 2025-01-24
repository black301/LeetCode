public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] strings = s.Split();
        Dictionary<char,string> dic = new Dictionary<char,string>();
        if(strings.Length!=pattern.Length)return false;
        for(int i = 0; i < strings.Length; i++)
        {
            
            if(dic.Values.Contains(strings[i])&&!dic.Keys.Contains(pattern[i]))return false;
            if (!dic.TryAdd(pattern[i], strings[i]))
            {
                if (dic[pattern[i]] != strings[i])return false;
            }
        }
        return true;    
    }
}