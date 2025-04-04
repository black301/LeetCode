public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        int c = 0;
        for (int i = 0; i < s.Length && c<g.Length; i++) {
            if (s[i] >= g[c])
            {
                c++;
            } 
        }
        return c;
    }
}