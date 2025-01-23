public class Solution
{
    public string RemoveDigit(string number, char digit)
    {
        int max = 0;
        List<BigInteger> list = new List<BigInteger>();
        for(int i=0;i<number.Length;i++){
            if (number[i] == digit) {
                list.Add(BigInteger.Parse(number.Remove(i,1)));
            }
        }
         return list.Max().ToString();
    }
}