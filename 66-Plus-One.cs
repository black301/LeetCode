 public class Solution
 {
     public int[] PlusOne(int[] digits)
     {
         int carry = 0,temp;
         //int [] result = new int[digits.Length];
         digits[digits.Length-1]++;
         for (int i = digits.Length-1; i >= 0; i--)
         {
             digits[i] += carry;
             carry = 0;
             if (digits[i] / 10 != 0) {
                 carry = (digits[i] / 10);
                 digits[i] = digits[i]%10;
             }
         }
         if (carry != 0) {
             int[] result = new int[digits.Length + 1];
             Array.Copy(digits,result,digits.Length);
             result[0] = carry;
             return result;
         }  
         return digits;
     }
 }