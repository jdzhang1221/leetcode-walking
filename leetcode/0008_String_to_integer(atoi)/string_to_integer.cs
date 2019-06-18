using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode._0008_String_to_integer_atoi_
{
    public class string_to_integer
    {
        /*
         Implement atoi which converts a string to an integer.

         The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.
         
         The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.
         
         If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.
         
         If no valid conversion could be performed, a zero value is returned.

         Example 1:

         Input: "42"
         Output: 42
             */
        public static int MyAtoi(string str)
        {
            if(str==null || str.Trim().Length == 0) { return 0; }
            str = str.Trim();
            int sign = 1,start=0,len=str.Length;
            long sum = 0;
            var firstVal = str[0];
            if(firstVal.ToString()=="+")
            {
                sign = 1;
                start++;
            }
            else if (firstVal.ToString() == "-")
            {
                sign = -1;
                start++;
            }
            for (int i = start; i < len; i++)
            {
                if(!Char.IsDigit(str[i]))
                {
                    return (int)sum * sign;
                }
                sum = sum * 10 + str[i]-'0';
                if(sign==1 && sum > int.MaxValue)
                {
                    return int.MaxValue;
                }
                else if (sign == -1 && (-1)*sum < int.MinValue)
                {
                    return int.MinValue;
                }
            }
            return (int)sum * sign;
        }
    }
}
