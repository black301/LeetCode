public class Solution
{
    public int CountAsterisks(string s)
    {
        bool pair =true;
        int counter = 0;
        foreach (var item in s) {
            if (item=='|')pair = !pair;
            if (pair) { 
                if(item=='*')counter++;
            }
        }
        return counter;
    }
}