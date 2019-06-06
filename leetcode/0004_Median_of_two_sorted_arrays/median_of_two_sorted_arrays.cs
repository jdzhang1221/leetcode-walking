using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode._0004_Median_of_two_sorted_arrays
{
    public class median_of_two_sorted_arrays
    {
        #region
        //public static double FindMedianSortedArrays(int[] nums1,int[] nums2)
        //{
        //    int[] result = new int[(nums1?.Length ?? 0) + (nums2?.Length ?? 0)];
        //    for (int i = 0; i < nums1.Length; i++)
        //    {
        //        result[i] = nums1[i];
        //    }
        //    for (int i = 0; i < nums2.Length; i++)
        //    {
        //        result[nums1.Length+i] = nums2[i];
        //    }
        //    var resultMaoPao = MaoPao(result);
        //    if (resultMaoPao.Length % 2 == 0)
        //    {
        //        return  Math.Round( Convert.ToDouble(resultMaoPao[resultMaoPao.Length / 2 - 1] + resultMaoPao[resultMaoPao.Length / 2])/2,1) ;
        //    }
        //    else
        //    {
        //        return resultMaoPao[(resultMaoPao.Length - 1)/ 2] ;
        //    }
        //}
        ////冒泡排序
        //public static int[] MaoPao(int[] mid)
        //{
        //    int midResult = 0;
        //    for (int i = 0; i < mid.Length-1; i++)
        //    {
        //        for (int j = i+1; j < mid.Length; j++)
        //        {
        //            if (mid[i] > mid[j])
        //            {
        //                midResult = mid[j];
        //                mid[j] = mid[i];
        //                mid[i] = midResult;
        //            }
        //        }
        //    }
        //    return mid;
        //}
        #endregion

        /// <summary>
        /// Time complexity:O(log(min(m,n)))  Space Complexity:O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static double FindMedianSortedArrays(int[] A, int[] B)
        {
            int m = A.Length;
            int n = B.Length;
            if (m > n)
            {
                int[] temp = A; A = B; B = temp;
                int tmp = m;m = n;n = tmp;
            }
            int iMin = 0, iMax = m, halfLen = (m + n + 1) / 2;
            while (iMin<=iMax)
            {
                int i = (iMin + iMax) / 2;
                int j = halfLen - i;
                if(i<iMax && B[j - 1] > A[i])
                {
                    iMin = i + 1;
                }
                else if(i>iMin && A[i - 1] > B[j])
                {
                    iMax = i - 1;
                }
                else
                {
                    int maxLeft = 0;
                    if (i == 0)
                    {
                        maxLeft = B[j - 1];
                    }
                    else if (j == 0)
                    {
                        maxLeft = A[i - 1];
                    }
                    else
                    {
                        maxLeft = Math.Max(A[i-1],B[j-1]);
                    }
                    if ((m + n) % 2 == 1) { return maxLeft; }

                    int minRight = 0;
                    if (i == m) { minRight = B[j]; }
                    else if (i == n) { minRight = A[i]; }
                    else { minRight = Math.Min(B[j],A[i]); }

                    return (maxLeft + minRight) / 2.0;
                }
            }
            return 0.0;
        }
    }
}
