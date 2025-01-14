public class Solution {
   public int MostWordsFound(string[] sentences)
{
    int counter = 0;
    foreach (string sentence in sentences)
    {
        string[] words = sentence.Split();
        counter = Math.Max(counter, words.Length);
    }
    return counter;
}
}