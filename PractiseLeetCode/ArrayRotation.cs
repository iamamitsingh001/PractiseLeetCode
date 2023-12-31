using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode
{
    public class ArrayRotation
    {
        /// <summary>
        /// ArrayRotation
        /// </summary>
        /// <param name="nums">int[] nums = { 1, 2, 3, 4, 5, 6, 7 };</param>
        /// <param name="k"></param>
        public void Rotate(int[] nums, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int[] root = new int[nums.Length];
                root[0] = nums[nums.Length-1];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != nums.Length-1)
                    root[j+1] = nums[j];
                }
                nums = root;
            }
        }
    }
}
