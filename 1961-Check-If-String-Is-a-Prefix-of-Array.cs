public class Solution {
    public bool IsPrefixString(string s, string[] words)
 {
     string result = "";
     foreach (string word in words) {
         result += word ;
         if (result == s) return true;
     }
     return false;
 }
}