using leetcode._0003_Longest_Substring_Without_Repeating_Characters;
using static leetcode._0002_Add_Two_Numbers.add_two_numbers;
using System;
using leetcode._0004_Median_of_two_sorted_arrays;
using leetcode._0015_3Sum;
using leetcode._0007_Reverse_Integer;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 0001_Two Sum
            //int[] nums = new int[] { 2, 7, 11, 15 };
            //int target = 9;
            //var result = _0001_Two_Sum.two_sum.TwoSum(nums, target);
            //var result1 = _0001_Two_Sum.two_sum.TwoSum1(nums, target);
            #endregion

            #region 0002_Add Two Numbers
            //ListNode l1 = new ListNode(3);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);

            //ListNode l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            //var result= AddTwoNumbers(l1, l2);
            #endregion

            #region 0003_Longest Substring Without Repeating Characters
            //string input = "pwwkew";
            //var result= longest_substring_without_repeating_characters.LongestSubstringWithoutRepeatingCharacters(input);
            #endregion

            #region 0004_Median_of_two_sorted_arrays
            //int[] nums1 = new int[] { 1, 3 };
            //int[] nums2 = new int[] { 2 };
            //var result= median_of_two_sorted_arrays.FindMedianSortedArrays(nums1,nums2);
            #endregion

            #region 0005_Longest Palindromic Substring
            //string input = "ac";
            //var result= _0005_Longest_Palindromic_Substring.longest_palindromic_substring.LongestPalindrome(input);
            #endregion

            #region 0006_ZigZag Conversion
            //string s = "PAYPALISHIRING"; int numRows = 4;
            //var result= _0006_ZigZag_Conversion.zigzag_conversion.convert(s,numRows);
            #endregion

            #region 0007_Reverse_Integer
            int request = 153423649;
            var result= reverse_integer.Reverse(request);
            #endregion

            #region 0015_3Sum
            //int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            //var result= ThreeSum.ThreeSumFunction(nums);
            #endregion

            Console.Read();
        }
    }
}
