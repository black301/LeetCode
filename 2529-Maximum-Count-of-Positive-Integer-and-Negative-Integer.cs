 public class Solution
 {
     public int MaximumCount(int[] nums)
     {
         int countP = 0;
         int countN = 0;
         foreach (int num in nums) { 
             if (num > 0) countP++;
             if (num < 0) countN++;
         }
         return Math.Max(countP, countN);
     }
 }