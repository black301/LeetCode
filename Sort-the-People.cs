public class Solution
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        List<(int,string)> set = new List<(int, string)>();
        long n = names.Length;
        for (int i = 0; i < n; i++)
        {
            set.Add((heights[i], names[i]));
        }
        set.Sort();
        string[] result = new string[names.Length];
        for (int i = 0; i < n; i++)
        {
            result[i] = set[(int)n-i-1].Item2;;
        }
        return result;

    }
}