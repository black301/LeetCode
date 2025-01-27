public class Solution
{
    public int RearrangeCharacters(string s, string target)
    {
        int result = 101; 
        foreach (char c in target) {
            int countInS = s.Where(s => s == c).Count();
            int countInT = target.Where(s => s == c).Count();

            //Console.WriteLine($"{c}={count}");
            result =Math.Min(result,countInS/countInT);
        }
        return result;
    }
}