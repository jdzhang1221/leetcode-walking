using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode._0005_Longest_Palindromic_Substring
{
    /*
     Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

     Example 1:

     Input: "babad"
     Output: "bab"
     Note: "aba" is also a valid answer.
         */

    /// <summary>
    /// Time complexity: O(n^2) Space Complexity:O(1)
    /// </summary>
    public class longest_palindromic_substring
    {
        private static int startIndex, length;
        public static string LongestPalindrome(string s)
        {
            int len = s.Length;
            if (len < 2) { return s; }
            for (int i = 0; i < len-1; i++)
            {
                //For odd Length
                ExtendPalindrome(s, i, i);
                //For even Length
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
            int newLength = ((end - 1) - (start + 1)) + 1;
            if (length < newLength)
            {
                startIndex = start + 1;
                length = newLength;
            }
        }
    }
}
