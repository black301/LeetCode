public class Solution
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        HashSet<(int,string)> set = new HashSet<(int, string)>();
        for (int i = 0; i < names.Length; i++)
        {
            set.Add((heights[i], names[i]));
        }
        string[] result = new string[names.Length];
        for (int i = 0; i < names.Length; i++)
        {
            result[i] = set.Max().Item2;
            set.Remove(set.Max());
        }
        return result;

    }
}