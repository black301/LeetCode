using System.Text.RegularExpressions;
public class Solution
{
    public bool CheckString(string s)
    {
        Regex reg = new(\^a*b*$\);
        return reg.IsMatch(s);
    }
}