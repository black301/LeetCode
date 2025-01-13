
        public class Solution
        {
            public string ReversePrefix(string word, char ch)
            {
                if(!word.Contains(ch)) return word;
                int index = word.IndexOf(ch);
                char[] chars = word.Substring(0,index+1).ToCharArray();
                Array.Reverse(chars);
                return new string(chars)+word.Substring(index+1,word.Length-index-1);
            }
        }