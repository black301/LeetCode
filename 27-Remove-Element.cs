public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        List<int> list = new List<int>(nums);
        list.RemoveAll(new Predicate<int>(x => x == val));
        Array.Copy(list.ToArray(),nums,list.Count);
        return list.Count;
    }
}