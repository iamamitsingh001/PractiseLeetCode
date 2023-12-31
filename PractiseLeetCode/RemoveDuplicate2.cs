using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PractiseLeetCode
{
    public class RemoveDuplicate2
    {
        /// <summary>
        /// RemoveDuplicates
        /// </summary>
        /// <param name="nums">int[] nums = { 1, 1, 1, 2, 2, 3 };</param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length > 1)
            {
                int countmaxNum = 1;
                bool isDuplicate = false;
                nums[countmaxNum-1] = nums[0];
                for (int i = 0;i < nums.Length-1; i++)
                {
                    if ((nums[i] == nums[i+1] && isDuplicate == false) || nums[i] != nums[i+1])
                    {
                        isDuplicate = nums[i] == nums[i + 1];
                        nums[countmaxNum] = nums[i + 1];
                        countmaxNum ++;
                    }
                }
                return countmaxNum;
            }
            else
                return nums.Length;
        }
    }
}
