public class Solution
{
    public bool CanConstruct(string s, int k)
    {
        Dictionary<char,int>dic = new Dictionary<char,int>();
        int even = 0,odd = 0;
        if (k == s.Length)
        {
            return true;
        }else if (k > s.Length)
        {
            return false;
        }
        else
        {
            foreach (char c in s) { 
                if (!dic.ContainsKey(c))
                {
                    dic.Add(c, 1);
                }
                else
                {
                    dic[c]++;
                }
            }
            foreach (char c in dic.Keys)
            {
                if (dic[c] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            if (odd > k)
            {
                return false ;
            }else return true ;
        }
    }
}