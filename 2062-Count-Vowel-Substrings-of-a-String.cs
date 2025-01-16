using System.Text.RegularExpressions;
public class Solution
{
    public int CountVowelSubstrings(string word)
    {
        Regex req = new (@"^(?=.*a)(?=.*e)(?=.*i)(?=.*o)(?=.*u)[aeiou]+$");
        int counter = 0;
        for (int i = 0; i < word.Length - 4; i++)
        {
            for (int j = 4; i + j < word.Length; j++)
            {
                string substr = word.Substring(i, j + 1);
                if (req.IsMatch(substr))
                    counter++;
            }
        }
        return counter;
    }
}