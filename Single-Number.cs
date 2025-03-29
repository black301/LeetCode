public class Solution {
    public int SingleNumber(int[] nums) {
        var result = nums.GroupBy(x => x).Where(x => x.Count() == 1).Select(x=>x.Key).ToList();
return result[0];
    }
}