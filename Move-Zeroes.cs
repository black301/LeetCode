public class Solution
{
    public void MoveZeroes(int[] nums)
    {

        int x = 0;
        int c = 0;
        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] == 0)
            {
                x++;
            }
            else
            {
                nums[c++] = nums[i];
            }
        }
        for (int i = 0; i < x; i++)
        {
            nums[c++] = 0;
        }

    }
}