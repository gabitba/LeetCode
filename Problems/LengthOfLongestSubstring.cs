using System.Collections.Generic;

namespace LeetCode.Problems
{
    /* 
     * Given a string, find the length of the longest substring without repeating characters.
     * 
     * Example 1:
     * Input: "abcabcbb"
     * Output: 3
     * Explanation: The answer is "abc", with the length of 3.
     * 
     * Example 2:
     * Input: "bbbbb"
     * Output: 1
     * Explanation: The answer is "b", with the length of 1.
     * 
     * Example 3:
     * Input: "pwwkew"
     * Output: 3
     * Explanation: The answer is "wke", with the length of 3.
     * Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
     */

    public class LengthOfLongestSubstring
    {
        public static int Solution(string s)
        {
            int longestSubstringLength = 0; 
            Dictionary<char, int> substringDicAux = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!substringDicAux.ContainsKey(s[i]))
                {
                    substringDicAux.Add(s[i], i);
                }
                else
                {
                    if(substringDicAux.Count > longestSubstringLength)
                    {
                        longestSubstringLength = substringDicAux.Count;
                    }

                    i = substringDicAux[s[i]];

                    if (longestSubstringLength > (s.Length - i + 1))
                    {
                        break;
                    }

                    substringDicAux = new Dictionary<char, int>();
                }
            }

            return substringDicAux.Count > longestSubstringLength ? substringDicAux.Count : longestSubstringLength;
        }
    }
}
