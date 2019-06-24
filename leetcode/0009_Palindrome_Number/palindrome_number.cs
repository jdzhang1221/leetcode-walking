using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode._0009_Palindrome_Number
{
    /*
     Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
     Example 1:

     Input: 121
     Output: true

     Follow up:

     Coud you solve it without converting the integer to a string?
         */
    public class palindrome_number
    {
        /*
         Time Complexity:O(lg(n)) Space Complexity:O(1)
             */
        public static bool IsPalindrome(int x)
        {
            if(x<0 || (x%10==0 && x!=0))
            {
                return false;
            }
            int reverseNumber = 0;
            while (x>reverseNumber)
            {
                reverseNumber = reverseNumber * 10 + x % 10;
                x = x / 10;
            }
            return x == reverseNumber || x == reverseNumber / 10;
        }
    }
}
