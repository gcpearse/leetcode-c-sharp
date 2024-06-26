namespace LeetCodeCSharp.Easy;

public class FindAllNumbersDisappearedInAnArraySolution
{
  public static IList<int> FindDisappearedNumbers(int[] nums)
  {
    IList<int> result = [];

    for (int i = 1; i <= nums.Length; i++)
    {
      if (!nums.Contains(i)) result.Add(i);
    }

    return result;
  }
}


/*

Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.

Example 1:

Input: nums = [4, 3, 2, 7, 8, 2, 3, 1]
Output: [5, 6]

Example 2:

Input: nums = [1, 1]
Output: [2]

*/
