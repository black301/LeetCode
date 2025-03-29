public class Solution {
    public int SingleNumber(int[] nums) {
       
                var result = nums.GroupBy(x => x).Where(x=>x.Count()==1);
                return result.First().Key;
    }
}