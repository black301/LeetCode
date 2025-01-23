 public class Solution
 {
     public string AddStrings(string num1, string num2)
     {
         
         int carry = 0, len = Math.Max(num1.Length,num2.Length);
         num1=num1.PadLeft(len,'0');
         num2=num2.PadLeft(len,'0');
         string result = \\;
         for (int i = len-1; i >=0; i--)
         {
             int value = num1[i] - '0' + num2[i] - '0' + carry;
             result = (value%10).ToString()+result;
             carry = value/10;
         }
         if (carry != 0) result = carry.ToString()+result;
         return result;
     }
 }