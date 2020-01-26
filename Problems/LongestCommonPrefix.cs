using System.Linq;

namespace LeetCode.Problems
{
    /*
     * Write a function to find the longest common prefix string amongst an array of strings.
     * If there is no common prefix, return an empty string "".
     * 
     * Example 1:
     * Input: ["flower","flow","flight"]
     * Output: "fl"
     * 
     * Example 2:
     * 
     * Input: ["dog","racecar","car"]
     * Output: ""
     * Explanation: There is no common prefix among the input strings.
     * Note:
     * 
     * All given inputs are in lowercase letters a-z.
     * 
     */

    public static class LongestCommonPrefix
    {
        public static string Solution(string[] strs)
        {
            string common = "";

            if(strs.Any(str => !string.IsNullOrEmpty(str)))
            {
                int minLength = strs.Min(str => str.Length);

                for(int i = 0; i < minLength; i++)
                {
                    char c = strs[0][i];
                    if (strs.All(str => str[i] == c))
                    {
                        common += c;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return common;
        }
    }
}
