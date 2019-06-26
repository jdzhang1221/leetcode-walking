using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode._0020_Valid_Parentheses
{
    /*
     Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

     An input string is valid if:
     
     Open brackets must be closed by the same type of brackets.
     Open brackets must be closed in the correct order.
     Note that an empty string is also considered valid.

     Example 1:

     Input: "()"
     Output: true
     Example 2:
     
     Input: "()[]{}"
     Output: true
     Example 3:
     
     Input: "(]"
     Output: false
     Example 4:
     
     Input: "([)]"
     Output: false
     Example 5:
     
     Input: "{[]}"
     Output: true
         */
    public class valid_parentheses
    {
        // 初始化容器，存储 右边抵消的字符
        private static Dictionary<char, char> keyValuePairs;
        static valid_parentheses()
        {
            keyValuePairs = new Dictionary<char, char>();
            keyValuePairs.Add(')','(');
            keyValuePairs.Add(']', '[');
            keyValuePairs.Add('}', '{');
        }
        /// <summary>
        /// Time Complexity:O(n) Space Complexity:O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValid(string s)
        {
            //栈：先进后出;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char one = s[i];
                //判断当前字符是否需要抵消
                if (keyValuePairs.ContainsKey(one))
                {
                    //获取栈顶的第一个字符
                    char topElement = stack.Count == 0 ? '#' : stack.Pop();
                    //如果抵消字符和栈顶第一个元素不匹配 直接返回false
                    if (topElement != keyValuePairs[one])
                    {
                        return false;
                    }
                }
                else
                {
                    //如果字符是开区间，就把字符压入栈中
                    stack.Push(s[i]);
                }
            }
            return stack.Count == 0;
        }
    }
}
