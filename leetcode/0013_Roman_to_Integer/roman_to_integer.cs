﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode._0013_Roman_to_Interger
{
    /*
     Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
     Symbol       Value
     I             1
     V             5
     X             10
     L             50
     C             100
     D             500
     M             1000

     For example, two is written as II in Roman numeral, just two one's added together. 
     Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

     Roman numerals are usually written largest to smallest from left to right.
     However, the numeral for four is not IIII. Instead, the number four is written as IV. 
     Because the one is before the five we subtract it making four.
     The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

        I can be placed before V (5) and X (10) to make 4 and 9. 
        X can be placed before L (50) and C (100) to make 40 and 90. 
        C can be placed before D (500) and M (1000) to make 400 and 900.

     Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.

     Example 1:

     Input: "III"
     Output: 3
     Example 2:

     Input: "IV"
     Output: 4
     Example 3:
     
     Input: "IX"
     Output: 9
     Example 4:
     
     Input: "LVIII"
     Output: 58
     Explanation: L = 50, V= 5, III = 3.
     Example 5:
     
     Input: "MCMXCIV"
     Output: 1994
     Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
         */
    public class roman_to_integer
    {
        public static int RomanToInt(string s)
        {
            int sum = 0;
            if (s.IndexOf("IV") != -1) { sum = -2; }
            if (s.IndexOf("IX") != -1) { sum = -2; }
            if (s.IndexOf("XL") != -1) { sum = -20; }
            if (s.IndexOf("XC") != -1) { sum = -20; }
            if (s.IndexOf("CD") != -1) { sum = -200; }
            if (s.IndexOf("CM") != -1) { sum = -200; }

            var c = s.ToCharArray();
            for (int count = 0; count < s.Length; count++)
            {
                if (c[count] == 'M') sum += 1000;
                if (c[count] == 'D') sum += 500;
                if (c[count] == 'C') sum += 100;
                if (c[count] == 'L') sum += 50;
                if (c[count] == 'X') sum += 10;
                if (c[count] == 'V') sum += 5;
                if (c[count] == 'I') sum += 1;
            }
            return sum;
        }
    }
}
