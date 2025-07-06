public class FindSumPairs
{
    public Dictionary<int, int> dic = new Dictionary<int, int>();
    public int[] nums1;
    public int[] nums2;
    public FindSumPairs(int[] nums1, int[] nums2)
    {
        this.nums1 = nums1;
        this.nums2 = nums2;
        for (int i = 0; i < nums2.Length; i++)
        {
            if (!dic.TryAdd(nums2[i], 1))
            {
                dic[nums2[i]]++;
            }
        }
    }

    public void Add(int index, int val)
    {
        dic[nums2[index]]--;
        if (!dic.TryAdd(nums2[index] + val, 1))
        {
            dic[nums2[index] + val]++;
        }
        nums2[index] += val;
    }

    public int Count(int tot)
    {
        int result = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            if ( dic.ContainsKey(tot - nums1[i]))
            {
                result += dic[tot - nums1[i]];
            }
        }
        return result;
    }
}

/**
 * Your FindSumPairs object will be instantiated and called as such:
 * FindSumPairs obj = new FindSumPairs(nums1, nums2);
 * obj.Add(index,val);
 * int param_2 = obj.Count(tot);
 */