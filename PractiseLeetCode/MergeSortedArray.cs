using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode
{
    public class MergeSortedArray
    {
        #region Program to merge two sorted arrays in ascending order
        /// <summary>
        /// Program to merge two arrays in ascending order
        /// </summary>
        /// <param name="nums1">int[] nums1 = new int[6] { 10, 9, 12, 0, 0, 0 };</param>
        /// <param name="m">int m = 3;</param>
        /// <param name="nums2">int[] nums2 = new int[3] { 1, 2, 3 };</param>
        /// <param name="n">int n = 3;</param>
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            int i = m + n - 1;

            while (p2 >= 0)
            {
                if (p1 >= 0 && nums1[p1] > nums2[p2])
                    nums1[i--] = nums1[p1--];
                else
                    nums1[i--] = nums2[p2--];
            }
        }
        #endregion
    }
}
