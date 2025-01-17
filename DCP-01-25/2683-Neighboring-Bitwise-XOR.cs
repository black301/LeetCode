 public class Solution
 {
     public bool DoesValidArrayExist(int[] derived)
     {
         int numberOfOnes = 0;
         foreach (int i in derived) {
             if (i == 1) { 
                 numberOfOnes++;
             }
         }
         return numberOfOnes %2==0;
     }
 }