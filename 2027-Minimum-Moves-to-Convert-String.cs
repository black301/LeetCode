public class Solution
{
    public int MinimumMoves(string s)
    {
        int counter = 0;
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == 'X') { 
                counter++;
                i+=2;
            }
        }
        return counter;
    }
}