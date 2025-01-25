 public class Solution
 {
     public int PercentageLetter(string s, char letter)
     {
         Dictionary<char,decimal> result = new Dictionary<char,decimal>();
         foreach (char c in s) {
             if (!result.TryAdd(c, 1))
             {
                 result[c]++;
             }
         }
         if (result.ContainsKey(letter))
         {
             return (int)((result[letter] / s.Length)*100);
         }
         else return 0;
     }
 }