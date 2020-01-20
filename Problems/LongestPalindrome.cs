namespace LeetCode.Problems
{
    public static class LongestPalindrome
    {
        public static string Solution(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 1)
            {
                return s;
            }

            return SearchPalindrome(s, "");
        }

        public static string SearchPalindrome(string s, string longestPalindrome)
        {
            if(longestPalindrome.Length > s.Length)
            {
                return longestPalindrome;
            }

            int range = s.Length;
            int limitRange = 0;
            int endIndex = 0;
            int startIndex = 0;

            for (int i = 1; i <= range - limitRange; i++)
            {
                string subString = s.Substring(0, i);
                if (isPalindrome(subString) && subString.Length > longestPalindrome.Length)
                {
                    longestPalindrome = subString;
                }

                if (range - limitRange > s.Length / 2 + 1)
                {
                    if (s[startIndex] == s[range - endIndex - 1])
                    {
                        endIndex++;
                        startIndex++;
                    }
                    else
                    {
                        limitRange++;
                        startIndex = 0;
                        endIndex = limitRange;
                    }
                }
            }

            return SearchPalindrome(s.Substring(1, s.Length - 1), longestPalindrome);
        }

        private static bool isPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
