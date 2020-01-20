using System;

namespace LeetCode.Problems
{
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
