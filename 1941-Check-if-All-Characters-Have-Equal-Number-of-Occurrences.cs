 public class Solution
 {
     public bool AreOccurrencesEqual(string s)
     {
         Dictionary<char,int>dic = new Dictionary<char,int>();
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
         int x = dic[s[0]];
         foreach (char c in dic.Keys) {
             if (dic[c] != x)
             {
                 return false;
             }
         }
         return true;
         
     }
 }