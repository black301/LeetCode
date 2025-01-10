public class Solution {
    public bool IsAnagram(string s, string t) {
     
                Dictionary<char,int>dic = new Dictionary<char,int>();
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
                        dic[c]--;
                    }   
                }
                foreach (char c in dic.Keys) { 
    if (dic[c] != 0){
        return false;
    }
}
                return true;   
    }
}