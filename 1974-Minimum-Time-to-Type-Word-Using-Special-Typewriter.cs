 public class Solution
 {public int MinTimeToType(string word)
{
    char current = 'a';
    int result = 0;
    foreach (char c in word) {
        int second = Math.Abs(current - c);
        result += Math.Min(second,26-second)+1;
        current = c;    
    }
    return result;
}
 }