using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.LeetCodeProblems
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            int diff = 0,i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                diff = target - nums[i];
                if (diff == nums[j])
                {
                    result[0] = i;
                    result[1] = j;
                    break;
                }
                if (j == nums.Length - 1)
                {
                    i++;j = i;
                }
            }
            return result;
        }
    }
}
