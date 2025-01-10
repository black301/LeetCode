 public class Solution
 {
     public int GetLucky(string s, int k)
     {
         string result = "";
         foreach(char c in s)
         {
             result += ((int)(c - 'a' + 1)).ToString();
         }
         for(int i = 0; i < k; i++)
         {
             result = transform(result);
         }
         return int.Parse(result);
     }
     public string transform(string s)
     {
         int result = 0;
         foreach (char c in s)
         {
             result+=int.Parse(c.ToString());
         }
         return result.ToString();
     }
 }