using leetcode._0003_Longest_Substring_Without_Repeating_Characters;
using static leetcode._0002_Add_Two_Numbers.add_two_numbers;
using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Two_Sum
            //int[] nums = new int[] { 2, 7, 11, 15 };
            //int target = 9;
            //var result = _0001_Two_Sum.two_sum.TwoSum(nums, target);
            //var result1 = _0001_Two_Sum.two_sum.TwoSum1(nums, target);
            #endregion

            #region add two numbers
            //ListNode l1 = new ListNode(3);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);

            //ListNode l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            //var result= AddTwoNumbers(l1, l2);
            #endregion

            #region longest substring without repeating characters
            string input = "pwwkew";
            var result= longest_substring_without_repeating_characters.LongestSubstringWithoutRepeatingCharacters(input);
            #endregion

            Console.Read();
        }
    }
}
