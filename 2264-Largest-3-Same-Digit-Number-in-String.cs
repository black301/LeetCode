public class Solution
{
    public string LargestGoodInteger(string num)
    {
        List<string> result = new List<string>();
        result.Add("");
        for(int i = 0; i <= num.Length - 3; i++)
        {
            char temp=num[i];
            if (num[i+1]==temp && num[i + 2] == temp)
            {
                result.Add($"{temp}{temp}{temp}");
            }
        }
        return result.Max();
    }
}