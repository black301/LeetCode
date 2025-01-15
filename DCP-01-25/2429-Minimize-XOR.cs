 public class Solution
 {
     public int MinimizeXor(int num1, int num2)
     {
         int x = numberOfOnes(num2);//3
         int y = numberOfOnes(num1);//4
         string bin = Convert.ToString(num1, 2);
         string result = "";
         if (x > y)
         {
             x = x - y;
             for (int i = bin.Length - 1; i >= 0; i--)
             {
                 if (bin[i] == '0' && x > 0)
                 {
                    result = "1" + result;
                     x--;
                 }
                 else if (bin[i] == '1')
                 {
                     result = "1" + result;
                 }
                 else
                 {
                     result = "0" + result;
                 }
             }
             while (x != 0)
             {
                 result ="1"+result;
                 x--;
             }
             return Convert.ToInt32(result, 2);
         }
         else if (x < y)
         {
             for (int i = 0; i < bin.Length; i++)
             {
                 if (bin[i] == '1' && x > 0)
                 {
                     result += '1';
                     x--;
                 }
                 else
                 {
                     result += "0";
                 }
             }
             return Convert.ToInt32(result,2);
         }
         else
         {
             return num1;
         }

     }
     int numberOfOnes(int n)
     {
         int counter = 0;
         while (n != 0)
         {
             if (n % 2 == 1) counter++;
             n = n / 2;
         }
         return counter;
     }
 }