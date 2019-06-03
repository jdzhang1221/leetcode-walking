using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode._0003_Longest_Substring_Without_Repeating_Characters
{
    public class longest_substring_without_repeating_characters
    {
        #region  brute force
        /// <summary>
        /// Time complexity:O(n^3)  Space complexity:O(min(n,m)),the size of the string n and the size of the charset/alphabet m
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        //public static int LongestSubstringWithoutRepeatingCharacters(string input)
        //{
        //    int n = input.Length;
        //    int mid = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = i + 1; j <= n; j++)
        //        {
        //            if (IsAllUnique(input, i, j)) { mid = Math.Max(mid, j - i); }
        //        }
        //    }
        //    return mid;
        //}
        //public static bool IsAllUnique(string input, int start, int end)
        //{
        //    List<char> lstChar = new List<char>();
        //    char[] chars = input.ToCharArray();
        //    char mid;
        //    for (int i = start; i < end; i++)
        //    {
        //        mid = chars[i];
        //        if (lstChar.Contains(mid))
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            lstChar.Add(mid);
        //        }
        //    }
        //    return true;
        //}
        #endregion

        #region Sliding Window
        /*
         Time Complexity O(2n)=O(n)  Space Complexity O(min(m,n))
            */
        //public static int LongestSubstringWithoutRepeatingCharacters(string input)
        //{
        //    var chars = input.ToCharArray();
        //    int n = input.Length;
        //    HashSet<char> set = new HashSet<char>();
        //    int ans = 0, i = 0, j = 0;
        //    while (i < n && j < n)
        //    {
        //        if (!set.Contains(chars[j]))
        //        {
        //            set.Add(chars[j++]);
        //            ans = Math.Max(ans, j - i);
        //        }
        //        else
        //        {
        //            set.Remove(chars[i++]);
        //        }
        //    }
        //    return ans;
        //}
        #endregion

        #region skip all the elements in the range [i,j'] and let i to be j' directly
        public static int LongestSubstringWithoutRepeatingCharacters(string input)
        {
            int n = input.Length;
            int ans = 0;
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int j = 0, i = 0; j < n; j++)
            {
                if (keyValuePairs.ContainsKey(input[j]))
                {
                    i = Math.Max(keyValuePairs[input[j]], i);
                    keyValuePairs[input[j]] = j + 1;
                }
                else
                {
                    keyValuePairs.Add(input[j], j + 1);
                }
                ans = Math.Max(ans, j - i + 1);
            }
            return ans;
        }
        #endregion

        #region Assuming ACSII 128
        //public static int LongestSubstringWithoutRepeatingCharacters(string input)
        //{
        //    var chars = input.ToCharArray();
        //    int n = input.Length, ans = 0;
        //    int[] index = new int[128];
        //    for (int j=0, i = 0; j < n; j++)
        //    {
        //        i = Math.Max(index[chars[j]],i);
        //        ans = Math.Max(ans,j-i+1);
        //        index[chars[j]] = j + 1;
        //    }
        //    return ans;
        //}
        #endregion
    }
}
