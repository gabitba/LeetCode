namespace LeetCode.Problems
{
    public static class RomanToInt
    {
        /*
         * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
         * Symbol       Value
         * I             1
         * V             5
         * X             10
         * L             50
         * C             100
         * D             500
         * M             1000
         * For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.
         * 
         * Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
         *
         * I can be placed before V (5) and X (10) to make 4 and 9.
         * X can be placed before L (50) and C (100) to make 40 and 90.
         * C can be placed before D (500) and M (1000) to make 400 and 900.
         * 
         * Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.
         * 
         */

        public static int Solution(string s)
        {
            return RecursiveRomanToInt(s);
        }

        public static int RecursiveRomanToInt(string s)
        {
            if (s.Length > 2)
            {
                if (s[0] == s[1] && s[1] == s[2])
                {
                    return (ConvertToInt(s[0]) * 3) + RecursiveRomanToInt(s.Substring(3));
                }
            }

            if (s.Length > 1)
            {
                if (s[0] == s[1])
                {
                    return (ConvertToInt(s[0]) * 2) + RecursiveRomanToInt(s.Substring(2));
                }

                int? partialInteger = ConvertToInt(s.Substring(0, 2));
                if (partialInteger != null)
                {
                    return (int)partialInteger + RecursiveRomanToInt(s.Substring(2));
                }
            }

            if (s.Length > 0)
            {
                return ConvertToInt(s[0]) + RecursiveRomanToInt(s.Substring(1));
            }

            return 0;
        }

        public static int ConvertToInt(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }

        public static int? ConvertToInt(string s)
        {
            switch (s)
            {
                case "IV": return 4;
                case "IX": return 9;
                case "XL": return 40;
                case "XC": return 90;
                case "CD": return 400;
                case "CM": return 900;
                default: return null;
            }
        }
    }
}
