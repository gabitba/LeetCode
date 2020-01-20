using System.Collections.Generic;

namespace LeetCode.Problems
{
    /*
     * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
     * You may assume that each input would have exactly one solution, and you may not use the same element twice.
     * 
     * Example:
     * Given nums = [2, 7, 11, 15], target = 9,
     * Because nums[0] + nums[1] = 2 + 7 = 9,
     * return [0, 1].
     */

    public class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { i, map[complement] };
                }
                else
                {
                    if (!map.ContainsKey(nums[i]))
                        map.Add(nums[i], i);
                }
            }
            return new int[0];
        }
    }
}
