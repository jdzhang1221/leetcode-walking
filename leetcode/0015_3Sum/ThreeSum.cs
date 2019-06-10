using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode._0015_3Sum
{
    public class ThreeSum
    {
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
