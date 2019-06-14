using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode._0006_ZigZag_Conversion
{
    /*
     The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to
     display this pattern in a fixed font for better legibility)

     P   A   H   N
     A P L S I I G
     Y   I   R

     And then read line by line: "PAHNAPLSIIGYIR"

     Example 1:
     Input: s = "PAYPALISHIRING", numRows = 3
     Output: "PAHNAPLSIIGYIR"
         */

    /*
     explanation:
     1.Characters in row 0 are located at indexes k(2 * numRows - 2)
     2.Characters in row numRows−1 are located at indexes k(2 * numRows - 2)+numRows-1
     3.Characters in inner row i are located at indexes k(2 * numRows - 2)+i and (k+1)(2 * numRows - 2)-i
        */

    public class zigzag_conversion
    {
        /// <summary>
        /// Time Complexity O(n),Space Complexity O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public  static String convert(String s, int numRows)
        {
            if (numRows == 1) return s;
            StringBuilder stringBuilder = new StringBuilder();
            int n = s.Length;
            int cycleLen = 2 * numRows - 2;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j + i < n; j += cycleLen)
                {
                    stringBuilder.Append(s[j + i]);
                    if (i != 0 && i != numRows - 1 && j + cycleLen - i < n) 
                        stringBuilder.Append(s[j + cycleLen - i]);
                }
            }
            return stringBuilder.ToString();
        }
    }
}
