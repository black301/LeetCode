  public class Solution
  {
      public IList<int> FindDisappearedNumbers(int[] nums)
      {
          HashSet<int> set = new HashSet<int>();
          List<int> result = new List<int>();
          for (int i = 0; i < nums.Length; i++)
          {
              set.Add(nums[i]);
          }
          for (int i = 0; i < nums.Length; i++)
          {
              if (!set.Contains(i + 1))
              {
                  result.Add(i + 1);
              }
          }
          return result;
      }
  }