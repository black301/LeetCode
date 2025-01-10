        public class Solution
        {
            public int CountPrefixSuffixPairs(string[] words)
            {
                int count = 0;  
                for (int i =0;i<words.Length;i++) {
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (isPrefixAndSuffix(words[i], words[j]) &&i<j) count++;
                    }
                }
                return count;
            }
            public bool isPrefixAndSuffix(string str1 ,string str2)
            {
                if (str1.Length <= str2.Length)
                {
                    return str2.EndsWith(str1) && str2.StartsWith(str1);
                }
                else return false;
            }
        }