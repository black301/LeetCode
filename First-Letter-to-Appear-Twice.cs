 public class Solution
 {
     public char RepeatedCharacter(string s)
     {
         Dictionary<char, int> dic = new Dictionary<char, int>();
         foreach (char c in s)
         {
             if (!dic.TryAdd(c,1))
             {
                 return c;
             }
         }
         return ' ';
     }
 }