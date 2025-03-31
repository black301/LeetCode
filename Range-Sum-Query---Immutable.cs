 public class NumArray
 {
     int [] array;
     public NumArray(int[] nums)
     {
         array = new int[nums.Length];
         array[0]=nums[0];
         for (int i = 1; i < nums.Length; i++) {
             array[i] = nums[i] +array[i-1];
         }
     }

     public int SumRange(int left, int right)
     {
        if(left!=0)
            return array[right]-array[--left];
         else
            return array[right];
     }
 }
