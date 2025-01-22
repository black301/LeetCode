 public class Solution
 {
     public string CapitalizeTitle(string title)
     {
         string[] words = title.Split();
         string result = "";
         foreach (string word in words) {
             if (word.Length > 2) {
                result= string.Concat(result,word[0].ToString().ToUpper(),word.Substring(1).ToLower()," ");
             }else
               result= string.Concat(result,word.ToLower()," ");
         }
        return result.TrimEnd();
     }
 }