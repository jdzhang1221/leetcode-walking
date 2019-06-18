using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode._0007_Reverse_Integer
{
    /*
     Given a 32-bit signed integer, reverse digits of an integer.

     Example 2:

     Input: -123
     Output: -321
         */
    public class reverse_integer
    {
        /// <summary>
        /// Time Complexity:O(log(x))  Space Complexity:O(1)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x)
        {
            int result = 0;
            while (x!=0)
            {
                int mid = x % 10;
                x /= 10;
                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && mid > 7)) return 0;
                if (result < int.MinValue / 10 || (result == int.MinValue / 10 && mid < -8)) return 0;
                result = result * 10 + mid;
            }
            return result;
        }
    }
}
