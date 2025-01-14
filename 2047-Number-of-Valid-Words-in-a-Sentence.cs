using System.Text.RegularExpressions;
public class Solution
{
    public int CountValidWords(string sentence)
    {
        string[] words = sentence.Split();
        int counter = 0;
        Regex req = new (@"^([a-z]+(-?[a-z]+)?)?(!|\.|,)?$");
        foreach (string word in words)
        {
            if (word!="" && req.IsMatch(word))counter++;
        }
        return counter;
    }
}