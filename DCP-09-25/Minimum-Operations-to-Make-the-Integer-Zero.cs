 public class Solution
 {
     public int MakeTheIntegerZero(int num1, int num2)
     {
         long bits, temp=1,   x=num2, op=1 , y=num1;
         if(y < x)   return -1;
         if(x == y)  return  -1;

         while (temp > 0) { 
             temp = y - (x * op);
             bits = countBits(temp);
              if (temp > 1 && bits <= op || bits==op && temp ==1)
                 return (int)op;
             op++;
         }
         return -1;
     }
     public static int countBits(long number)
     {
         int count = 0;
         while (number != 0)
         {
             number &= number - 1;
             count++;
         }
         return count;
     }

    
 }