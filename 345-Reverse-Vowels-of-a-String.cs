public class Solution
{
    public string ReverseVowels(string s)
    {
        char[] chars = s.ToCharArray();
        List<string> vowels = new List<string>() {\A\,\E\,\U\,\O\,\I\};
        int l = 0, r=s.Length-1;

        while (l < r) { 
            if (!vowels.Contains(chars[l].ToString().ToUpper())) l++;
            if (!vowels.Contains(chars[r].ToString().ToUpper())) r--;
            if(vowels.Contains(chars[l].ToString().ToUpper()) && vowels.Contains(chars[r].ToString().ToUpper()))
            {
                (chars[l], chars[r]) = (chars[r], chars[l]);
                l++;r--;
            }
        }
        return new string(chars);
    }
}