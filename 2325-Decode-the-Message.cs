public class Solution
{
    public string DecodeMessage(string key, string message)
    {
        int counter = 'a';
        string result="";
        Dictionary<char,char> dic = new Dictionary<char,char>();
        foreach (char c in key){
            if(c!=' ')
            if(dic.TryAdd(c,(char)counter))counter++;
        }
        foreach (char c in message)
        {
            if(c==' ')result += c;
            else  result += dic[c];
        }
        return result;
    }
   
}