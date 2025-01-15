  public class Solution
  {
      public bool CheckAlmostEquivalent(string word1, string word2)
      {
          Dictionary<char ,int> dic1 = new Dictionary<char ,int>();
          Dictionary<char ,int> dic2 = new Dictionary<char ,int>();
          for(int i = 0; i< word1.Length; i++)
          {
              if (!dic1.TryAdd(word1[i], 1)) dic1[word1[i]]++;
              if (!dic2.TryAdd(word2[i], 1)) dic2[word2[i]]++;
          }
          int num1, num2;
          for(char x = 'a'; x <= 'z'; x++)
          {
              num1 = dic1.ContainsKey(x) ? dic1[x] : 0; 
              num2 = dic2.ContainsKey(x) ? dic2[x] : 0;
              if (Math.Abs(num1-num2)>3)return false;
          }
          return true;
      }
  }