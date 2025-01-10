 public class Solution
 {
     public IList<string> WordSubsets(string[] words1, string[] words2)
     {
         List<string> result = new List<string>();
         Dictionary<char, int> main = new Dictionary<char, int>();
         
         foreach (string word in words2)
         {
             Dictionary<char, int> dic = new Dictionary<char, int>();
             foreach (char c in word)
             {
                 if (!dic.ContainsKey(c))
                 {
                     dic.Add(c, 1);
                 }
                 else
                 {
                     dic[c]++;
                 }
             }
             foreach (char c in dic.Keys) {
                 if (!main.ContainsKey(c)){ 
                     main.Add(c, dic[c]);
                 }
                 else
                 {
                     main[c] = Math.Max(main[c], dic[c]);
                 }
             }   
         }
         foreach (string word in words1) {
             if (ISUniversal(main, word))
             {
                 result.Add(word);
             }
         }
         return result;
     }
     public bool ISUniversal(Dictionary<char, int> dic, string word)
     {
         Dictionary<char, int> dic2 = new Dictionary<char, int>(dic);
         foreach (char c in word)
         {
             if (dic2.ContainsKey(c))
             {
                 dic2[c]--;
             }
         }
         foreach (char c in dic2.Keys)
         {
             if (dic2[c] > 0)
             {
                 //Console.WriteLine($"key = {c} value = {dic2[c]}");
                 return false;
             }
         }
         return true;
     }
 }