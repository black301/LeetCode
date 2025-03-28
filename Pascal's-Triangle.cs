public class Solution
{
    public IList<IList<int>> Generate(int numRows) 
    {
        List<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < numRows; i++)
        {
            List<int> temp = new List<int>();
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                    temp.Add(1);
                else
                    temp.Add(result[i - 1][j] + result[i - 1][j - 1]);
            }
            result.Add(temp);
        }
        return result;
    }
}
