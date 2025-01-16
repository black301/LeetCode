 public class Solution
 {
     public int XorAllNums(int[] nums1, int[] nums2)
     {
         int num1 = 0, num2 = 0;
         if (nums2.Length % 2 != 0)
         {
             foreach (int i in nums1)
             {
                 num1 ^= i;
             }
         }
         if (nums1.Length % 2 != 0)
         {
             foreach (int i in nums2)
             {
                 num2 ^= i;
             }
         }
         return num1 ^ num2;
     }
 }