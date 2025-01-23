public class Solution
{
    public IList<string> CellsInRange(string s)
    {
        List<string> result = new List<string>();
        for(char i = s[0]; i <= s[3]; i++)
        {
            for(char x=s[1] ; x<=s[4] ; x++)
            {
                result.Add(string.Concat(i, x));
            }
        }
        return result;
    }
}