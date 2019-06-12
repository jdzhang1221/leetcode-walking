using System;
using System.Collections.Generic;

namespace leetcode._0015_3Sum
{
    /*
     Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique
     triplets in the array which gives the sum of zero.

     Note:
     
     The solution set must not contain duplicate triplets.

     Example:

     Given array nums = [-1, 0, 1, 2, -1, -4],
     
     A solution set is:
     [
       [-1, 0, 1],
       [-1, -1, 2]
     ]
         */
    public class ThreeSum
    {
        /// <summary>
        /// Time Complexity O(n^2)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> ThreeSumFunction(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                {
                    int before = i + 1, after = nums.Length - 1, sum = 0 - nums[i];
                    while (before < after)
                    {
                        if (nums[before] + nums[after] == sum)
                        {
                            res.Add(new List<int> { nums[i], nums[before], nums[after] });
                            while (before < after && nums[before] == nums[before + 1])
                            {
                                before++;
                            }
                            while (before < after && nums[after] == nums[after - 1])
                            {
                                after--;
                            }
                            before++; after--;
                        }
                        else if (nums[before] + nums[after] < sum)
                        {
                            before++;
                        }
                        else { after--; }
                    }
                }
            }
            return res;
        }
    }
}
