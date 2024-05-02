namespace LengthOfLastWord;

public class Solution
{
  public static int LengthOfLastWord(string s)
  {
    string str = s.Trim();
    int count = 0;

    for (int i = str.Length - 1; i >= 0; i--)
    {
      if (str[i] != ' ')
      {
        count++;
      }
      else
      {
        break;
      }
    }

    return count;
  }

  public static void Test()
  {
    Console.WriteLine(LengthOfLastWord("Hello World"));
    // 5
    Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
    // 4
    Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
    // 6
  }
}


/* 

Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal substring consisting of non-space characters only.

Example 1:

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.

Example 2:

Input: s = "   fly me   to   the moon  "
Output: 4
Explanation: The last word is "moon" with length 4.

Example 3:

Input: s = "luffy is still joyboy"
Output: 6
Explanation: The last word is "joyboy" with length 6.

*/
