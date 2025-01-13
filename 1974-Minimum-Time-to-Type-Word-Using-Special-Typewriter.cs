 public class Solution
 {
     public int MinTimeToType(string word)
     {
         char current = 'a';
         int result = 0;
         foreach (char c in word) { 
             if (c != current) 
             result += Math.Min(Math.Abs(current-c),Math.Min(Math.Abs((current-'a')+'z'-c)+1, Math.Abs((current - 'z') + 'a' - c) + 1));
             //Console.WriteLine($"Math.Abs({current}-{c}) {Math.Abs(current - c)} Math.Abs(({current}-'a')+'z'-{c})+1): {Math.Abs((current - 'a') + 'z' - c)}");
             current = c;
             result++;       
             //Console.WriteLine(result);
         }
         return result;
     }
 }