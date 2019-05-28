using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Two_Sum
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            var result = _0001_Two_Sum.two_sum.TwoSum(nums, target);
            var result1 = _0001_Two_Sum.two_sum.TwoSum1(nums, target);
            #endregion
            Console.Read();
        }
    }
}
