public class Solution
{
    public IList<string> StringMatching(string[] words)
    {
        List<string> result = new List<string>();
        foreach (string word in words) {
            foreach (string word2 in words)
            {
                if (word2!=word && word.Contains(word2)) { 
                    if (!result.Contains(word2)) 
                    result.Add(word2);
                }
            }
        }
        return result;
    }
}