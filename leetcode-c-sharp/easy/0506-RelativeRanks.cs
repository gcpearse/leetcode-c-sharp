namespace RelativeRanks;

public class Solution
{
  public static string[] FindRelativeRanks(int[] score)
  {
    int[] scoreCopy = [.. score];

    Array.Sort(scoreCopy);
    Array.Reverse(scoreCopy);

    Dictionary<int, string> ranks = [];

    for (int i = 0; i < scoreCopy.Length; i++)
    {
      if (i == 0)
      {
        ranks.Add(scoreCopy[i], "Gold Medal");
      }
      else if (i == 1)
      {
        ranks.Add(scoreCopy[i], "Silver Medal");
      }
      else if (i == 2)
      {
        ranks.Add(scoreCopy[i], "Bronze Medal");
      }
      else
      {
        ranks.Add(scoreCopy[i], $"{i + 1}");
      }
    }

    List<string> result = [];

    foreach (int record in score)
    {
      result.Add(ranks[record]);
    }

    return [.. result];
  }

  public static void Test()
  {
    Console.WriteLine($"[{string.Join(", ", FindRelativeRanks([5, 4, 3, 2, 1]))}]");
    // ["Gold Medal", "Silver Medal", "Bronze Medal", "4", "5"]
    Console.WriteLine($"[{string.Join(", ", FindRelativeRanks([10, 3, 8, 9, 4]))}]");
    // ["Gold Medal", "5", "Bronze Medal", "Silver Medal", "4"]
  }
}


/*

You are given an integer scoreCopy score of size n, where score[i] is the score of the ith athlete in a competition. All the scores are guaranteed to be unique.

The athletes are placed based on their scores, where the 1st place athlete has the highest score, the 2nd place athlete has the 2nd highest score, and so on. The placement of each athlete determines their rank:

The 1st place athlete's rank is "Gold Medal".
The 2nd place athlete's rank is "Silver Medal".
The 3rd place athlete's rank is "Bronze Medal".
For the 4th place to the nth place athlete, their rank is their placement number (i.e., the xth place athlete's rank is "x").
Return an scoreCopy answer of size n where answer[i] is the rank of the ith athlete.

Example 1:

Input: score = [5, 4, 3, 2, 1]
Output: ["Gold Medal", "Silver Medal", "Bronze Medal", "4", "5"]
Explanation: The placements are [1st, 2nd, 3rd, 4th, 5th].
Example 2:

Input: score = [10, 3, 8, 9, 4]
Output: ["Gold Medal", "5", "Bronze Medal", "Silver Medal", "4"]
Explanation: The placements are [1st, 5th, 3rd, 2nd, 4th].

*/
