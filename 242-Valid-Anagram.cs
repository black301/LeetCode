        public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                Dictionary<char,int>dic = new Dictionary<char,int>();
                int x= s.Length;
                foreach (char c in s) {
                    if (dic.ContainsKey(c)) { 
                        dic[c]++;
                    }
                    else
                    {
                        dic.Add(c, 1);
                    }
                }
                foreach (char c in t) {
                    if (!dic.ContainsKey(c) || dic[c]==0) { 
                        return false;
                    }
                    else
                    {
                        x--;
                        dic[c]--;
                    }
                }
                if (x != 0)
                {
                    return false; ;
                }
                return true;
            }
        }