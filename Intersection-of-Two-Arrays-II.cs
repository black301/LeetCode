public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        int[] freqX = new int[1001];
        int[] freqY = new int[1001];
        List<int> result = new List<int>();
        for (int i = 0; i < Math.Max(nums1.Length, nums2.Length); i++)
        {
            if (i < nums1.Length) freqX[nums1[i]]++;
            if (i < nums2.Length) freqY[nums2[i]]++;
        }
        for (int i = 0; i < 1001; i++)
        {
            int x= Math.Min(freqX[i], freqY[i]);
            while(x--!=0) result.Add(i);
        }
        return result.ToArray();
    }
}