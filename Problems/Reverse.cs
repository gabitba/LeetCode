using System;

namespace LeetCode.Problems
{
    /*
     * Given a 32-bit signed integer, reverse digits of an integer.
     * Example 1:
     * Input: 123
     * Output: 321
     * 
     * Example 2:
     * Input: -123
     * Output: -321
     * Example 3:
     * Input: 120
     * Output: 21
     * 
     * Note:
     * Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
     * 
     */

    public static class Reverse
    {
        public static int Solution(int x)
        {
            try
            {
                return ReverseRecursive(x, 0);
            }
            catch
            {
                return 0;
            }
        }

        private static int ReverseRecursive(int x, int reverse)
        {
            if(x == 0)
            {
                return reverse;
            }

            double reverseDouble = ((double)reverse * 10) + (x % 10);

            reverse = Convert.ToInt32(reverseDouble);
            
            return ReverseRecursive(x / 10, reverse);
        }
    }
}
