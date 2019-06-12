using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode._0005_Longest_Palindromic_Substring
{
    public class longest_palindromic_substring
    {
        private static int startIndex, length;
        public static string LongestPalindrome(string s)
        {
            int len = s.Length;
            if (len < 2) { return s; }
            for (int i = 0; i < len-1; i++)
            {
                ExtendPalindrome(s, i, i);
                ExtendPalindrome(s, i, i + 1);
            }
            return s.Substring(startIndex, length);
        }

        public  static void ExtendPalindrome(string s,int start,int end)
        {
            while(start >= 0 && end < s.Length && s[start] == s[end])
            {
                start--;
                end++;
            }
            if (length < end-start-1 )
            {
                startIndex = start + 1;
                length = end - start - 1;
            }
        }
    }
}
