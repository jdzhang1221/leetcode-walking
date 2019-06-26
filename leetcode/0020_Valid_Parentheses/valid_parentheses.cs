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
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char one = s[i];
                if (keyValuePairs.ContainsKey(one))
                {
                    char element = stack.Count == 0 ? '#' : stack.Pop();
                    if (element != keyValuePairs[one])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
            return stack.Count == 0;
        }
    }
}
