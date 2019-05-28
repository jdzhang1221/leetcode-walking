using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode._0001_Two_Sum
{
    public class two_sum
    {
        /// <summary>
        /// 时间复杂度 O（n^2）  空间复杂度O（1）
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// 时间复杂度O（n） 空间复杂度O（n）
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum1(int[] nums, int target)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (keyValuePairs.ContainsKey(complement))
                {
                    return new int[] { keyValuePairs[complement], i };
                }
                if (!keyValuePairs.ContainsKey(nums[i]))
                {
                    keyValuePairs.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}
