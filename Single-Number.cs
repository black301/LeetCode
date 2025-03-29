public class Solution {
    public int SingleNumber(int[] nums) {
var result = nums.GroupBy(x => x).OrderBy(x=>x.Count());
return result.First().Key;    }
}